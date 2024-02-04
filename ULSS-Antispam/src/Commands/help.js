/** @format */

const Command = require("../Structures/Command.js");

const Discord = require("discord.js");

module.exports = new Command({
	name: "help",
	description: "Contains a list with all commands",
	permission: "ADMINISTRATOR",
	async run(message, args, client) {
		message.delete();
		const embed = new Discord.MessageEmbed();

		embed
			.setTitle("Commands")
			.setColor("GREY")
			.addFields(
				{
					name: "**!help**",
					value: "Displays all commands.",
				},
			)
			.setFooter(client.user.username, client.user.displayAvatarURL());

		message.channel.send({ embeds: [embed] });
		message.delete();
	}
});
