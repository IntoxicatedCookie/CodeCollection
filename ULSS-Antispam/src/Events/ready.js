const Event = require('../Structures/Event.js');

module.exports = new Event('ready', client => {
	console.log('Bot is ready!');
	client.user.setActivity('suspicious links', { type: 'WATCHING' });
});
