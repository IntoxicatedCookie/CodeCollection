/** @format */

const Command = require("../Structures/Command.js");

const Discord = require("discord.js");

module.exports = new Command({
	name: "test",
	description: "Contains a list with all commands",
	permission: "BAN_MEMBERS",
	async run(message, args, client) {
		message.channel.send(`${args[1]}`);
	}
});
