# Discord-Chat-Importer 
Discord-Chat-Importer allows you to import Discord channels and chats (exported from [DiscordChatExporter](https://github.com/Tyrrrz/DiscordChatExporter)) across Discord servers.

# Steps
## 1. Export a channel to .json
* Download [DiscordChatExporter](https://github.com/Tyrrrz/DiscordChatExporter/releases)
* Use DiscordChatExporter to export a channel to **.json** format:
<br></br> [![Export Tutorial](https://i.imgur.com/78Ejkhp.jpg)](https://m.youtube.com/watch?v=tt-TBOWLyJk)

## 2. Create the bot
* Go to: https://discord.com/developers/applications
* Click "New Application" on the top-right.
* Give it a name and press `Create`
* On the left panel, click `Bot`
* Click `Add Bot`
* Copy the Token, you'll need this for later steps. (If you don't see a token, click "Reset")
* On the left panel again, click 'URL Generator' under `OAuth2`
* Under Scopes, check `Bot`
* Under Bot Permissions, check `Read Messages/View Channels, Send Messages, Manage Messages, Embed Links, Attach Files, Read Message History`
* Copy the URL generated under Scopes and paste it into your browser
* Select the server you want the bot in

**WARNING:** DO NOT try to use the bot in multiple servers at once as it was designed to only support 1. Create more bots if you have to.

## 3. Download .NET 6
https://dotnet.microsoft.com/en-us/download/dotnet/6.0

## 4. Start the bot
* Download the executable from: https://github.com/Ethorbit/Discord-Chat-Importer/releases
* Open the Command Prompt or Terminal
* Run the executable with the argument as the token:
       <details>
           <summary>Windows</summary>
             <code>"C:\Users\Joe\Downloads\Discord-Channel-Importer.exe" "MQENWQKNQWKRNWQRQOWR.WQEOJQWEODN3AKDNAKNXeIA"</code>
       </details>
       <details>
           <summary>Linux</summary>
             <code>"/home/Joe/Downloads/Discord-Channel-Importer" "MQENWQKNQWKRNWQRQOWR.WQEOJQWEODN3AKDNAKNXeIA"</code>
       </details>

## 5. Import the .json

* Upload the .json to a url that will display its raw text:
   <details>
      <summary>Dropbox</summary>
        * https://www.dropbox.com/s/c5rvnig3pzeackp/Ethorbit%27s%20server%20-%20Text%20Channels%20-%20fkin-general%20%5B892291310927622204%5D.json?dl=0&raw=1
       (Copied link with &raw=1 added at the end)
   </details>

* Enter the command in: `!importer import <url> #channel`
<br></br> ![Import Preview](https://i.imgur.com/SZ1bOq9.png)

# Bot Commands
You need the Manage Messages and Manage Channels permissions to use the bot commands.
<br></br>Type `!importer help` for the command list.
* ![Command Preview](https://i.imgur.com/I684Agh.png)
