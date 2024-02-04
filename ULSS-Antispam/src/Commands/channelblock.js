/** @format */

const Command = require("../Structures/Command.js");

const Discord = require("discord.js");

module.exports = new Command({
	name: "channelblock",
	description: "Block all YouTube video's from a specific YouTube channel.",
	permission: "ADMINISTRATOR",
	async run(message, args, client) {
		message.channel.send(`${args[1]}`);
	}
});
