# Blockchain-P2P-Network
Implementing a simple blockchain system in .NET Core
## What is a P2P network
P2P stands for Peer-To-Peer. In plain English, a P2P network is created when two or more computers are connected and share resources without going through a separate server computer. All computers in a P2P network have the equal privilege. There is no need for central coordination. A computer in a P2P network is usually called a node. One of the most famous P2P systems is Napster, a file sharing system.
## What is a blockchain 
The blockchain is a decentralized, distributed database. The data in a Blockchain will reside at every single node of the Blockchain network. There are always computers join the network and computers left the network, so we can’t rely on a particular computer for storing data and exchanging data. Therefore, a P2P network is the best option for building a Blockchain network.
## what is a WebSocket
There are a lot of ways to implement a P2P network, for demo purposes, I decided to use a high-level protocol, WebSocket. WebSocket provides full-duplex communication channels over a single TCP connection. It is located at layer 7 in the OSI model. The WebSocket handshake uses the HTTP Upgrade header to change from the HTTP protocol to the WebSocket protocol.

 ## How to run the project
The steps are very easy you only have to
* Check if .NET Core sdk version 2.1 installed on your system, you can download it from [Here](https://www.microsoft.com/net/download/dotnet-core/2.1) then check if the instalation has gone correctly by typing
      
      user$ dotnet --version
      user$ 2.1.402
* Restore the dependencies by typing the commande
  
      user$ dotnet restore
* Finnaly go and run the app by typing

      user$ dotnet run <username>
* Support me by making a <img style="margin-bottom: -20px;" src="https://user-images.githubusercontent.com/24621701/44811262-193e6e00-abcc-11e8-8e61-e52d8c78d5c9.png" /> for the repo and thank you :D , If you want to contribute to the project and make it better, your help is very welcome. 
