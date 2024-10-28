<h1 align="center" style="font-weight: bold;">26-28sweNameless 💻</h1>

<p align="center">
 <a href="#tech">Technologies</a> • 
 <a href="#started">Getting Started</a> • 
  <a href="#routes">API Endpoints</a> •
 <a href="#colab">Collaborators</a> •
 <a href="#contribute">Contribute</a>
</p>

<p align="center">
    <b>The 26-28sweNamelessBE API provides endpoints for managing events and their venues. This collection allows users to retrieve, create, update, and delete both events and venues. It is designed to facilitate interactions with a collection of events and their respective venues in an organized and user-friendly way. Users are also able to RSVP to events they would like to attend.</b>
</p>

<h2 id="technologies">💻 Technologies</h2>

- list of all technologies you used
- C#
- .NET
- SQL
- Postman

<h2 id="started">🚀 Getting started</h2>

1.) Clone a repository option in Visual Studio 
2.) Enter or type the repository location, and then select the Clone button<br>

In the terminal enter the following: 
3.) ```bash
dotnet ef --version
```
4.) ```bash
dotnet tool install --global dotnet-ef
```
5.) ```bash
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 6.0
```
6.) ```bash
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0
```
7.) ```bash
dotnet user-secrets set "_26_28sweNamelessBEDbConnectionString"
```
8.)```bash
dotnet user-secrets set "_26_28sweNamelessBEDbConnectionString"
```
9.)```bash
"Host=localhost;Port=5432;Username=postgres;Password="YourPgAdminPassword"!;Database=_26_28sweNamelessBE"
```
10.)```bash
"dotnet ef database update"
```
11.) To start building the program, press the green Start button on the Visual Studio toolbar, or press F5 or Ctrl+F5. Using the Start button or F5 runs the program under the debugger.

<h3>Prerequisites</h3>

Here you list all prerequisites necessary for running your project. For example:

- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

<h3>Cloning</h3>

How to clone your project

```bash
git clone git@github.com:rossm933/26-28sweNamelessBE.git
```

<h3>Starting</h3>

How to start your project

```bash
cd 26-28sweNamelessBE
dotnet watch run
```

<h2 id="routes">📍 API Endpoints</h2>

​
| route               | description                                          
|----------------------|-----------------------------------------------------
| <kbd>GET /events</kbd>     | Retrieves events
| <kbd>GET /events/{id}</kbd>     | Retrieves individual event by id
| <kbd>GET /events/users/{uid}</kbd>     | Retrieves events by uid
| <kbd>POST /events</kbd>     | Creates a new event
| <kbd>PUT /events/{id}</kbd>     | Update an event
| <kbd>DELETE /events/{id}</kbd>     | Deletes an event by id
| <kbd>GET /venues</kbd>     | Retrieves venues
| <kbd>GET /venues/{id}</kbd>     | Retrieves individual venue by id
| <kbd>GET /venues/users/{uid}</kbd>     | Retrieves venues by uid
| <kbd>POST /venues</kbd>     | Creates a new venue
| <kbd>PUT /venues/{id}</kbd>     | Update a venue
| <kbd>DELETE /venues/{id}</kbd>     | Deletes a venue by id
| <kbd>GET /rsvps/users/{uid}</kbd>     | Retrieves RSVPs by uid
| <kbd>POST /rsvps</kbd>     | Creates a new RSVP
| <kbd>DELETE /rsvps/{id}</kbd>     | Deletes an rsvp by id


<h2 id="colab">🤝 Collaborators</h2>

Special thank you for all people that contributed for this project.

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/rossm933">
        <img src="https://avatars.githubusercontent.com/u/148557558?v=4" width="100px;" alt="Ross Morgan Profile Picture"/><br>
        <sub>
          <b>Ross Morgan</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/104770521?v=4" width="100px;" alt="Haley Smith Profile Picture"/><br>
        <sub>
          <b>Haley Smith</b>
        </sub>
      </a>
    </td>
  </tr>
</table>

<h2 id="contribute">📫 Contribute</h2>

Here you will explain how other developers can contribute to your project. For example, explaining how can create their branches, which patterns to follow and how to open an pull request

1. `git clone git@github.com:rossm933/26-28sweNamelessBE.git`
2. `git checkout -b feature/NAME`
3. Follow commit patterns
4. Open a Pull Request explaining the problem solved or feature made, if exists, append screenshot of visual modifications and wait for the review!

<h3>Documentations that might help</h3>

[📝 How to create a Pull Request](https://www.atlassian.com/br/git/tutorials/making-a-pull-request)

[💾 API Postman Documentation]()
