# Dockerization and Kubernetes a basic ASP.NET Core App

**Please don't check my coding (eg. how httpClient is used), this is a solution about how you can have a kubernetes cluster locally up and running with Docker Desktop**

Basically Visual Studio 2019 automates a lot of the stuff, so if everything goes well with this setup you should be able to just push F5 and debug.

So here are what is in side this solution:

- WebFrontEnd : This is just a very basic Razor pages project, where each link in the navbar calls the back end server
- WebApi : This is a basic Web API, that has the default weather forecast returned in one endpoint, also there is a few redis cache calls made, and a call is also made to a database running in 
a container.

See images in repo, regarding how VS and Docker dashboard should look like.
