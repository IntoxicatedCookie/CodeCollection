const Event = require("../Structures/Event.js");
const URIjs = require('urijs');
const { URL } = require('url');
const urlMeta = require('url-metadata');
const { Permissions } = require("discord.js");
const fs = require('fs');
const path = require("path");
const config = require("../Data/config.json");

const nvt = require('node-virustotal');
const nvtapi = nvt.makeAPI().setKey("REDACTED");


function checkMetadata(url, msg, client) {
 try {
	const excludes = ["discord.com", "discord.gift"];

	if (!excludes.some(site => url.toLowerCase().includes(site))) {
		hashedURL = nvt.sha256(url);
		nvtapi.urlLookup(hashedURL, function(err, res) {

		if (err) {
			parsedErr = JSON.parse(err);

			if (parsedErr['code'] === "429") {
				msg.delete();
				return msg.channel.send(`⚠ Maximum requests to VirusTotal reached. **Scams must be manually reviewed until tomorrow!**`);
			} else {
				msg.delete();
				console.log(err);
				return msg.channel.send(`🛡 Potential scam spam by <@${msg.author.id}> deleted.`);
			}
		} else {
			console.log(JSON.stringify(res))
			if (res['attributes']['last_analysis_stats'])  {
				msg.delete();
				msg.channel.send(`🛡 Scam spam by <@${msg.author.id}> deleted.`);
			}
		}
		});
	}

	//fs.appendFile(`blacklist.txt`, `${url}\n`, function(err) {
		//if (err) 
		//	return console.error(err); 
//	});
//
  } catch (err) {
	  console.error(err);
  }
}


module.exports = new Event("messageCreate", (client, msg) => {
	if (msg.author.bot || msg.channel === "DM") {
		return;
	}

	const filter = ["cs:go", "csgo", "cs go", "counter strike", "counter strike global offensive", "cstrike", "nitro", "free nitro", "dnitro", "discord nitro"];

	if (filter.some(word => msg.content.toLowerCase().includes(word)) && URIjs.withinString(msg.content, function(url) {
		checkMetadata(url, msg, client);
	}))		

	if (msg.content.startsWith(client.prefix)) {
		const args = msg.content.substring(client.prefix.length).split(/ +/)
		const command = client.commands.find(cmd => cmd.name == args[0]);

		if (!command) { return; }

		const permission = msg.member.permissions.has(command.permission, true);

		if (!permission) {
			msg.delete();
			return msg.channel.send(`⛔ <@${msg.author.id}>, you don't have permission to execute this command!`);
		}

		command.run(msg, args, client);
	}
});
