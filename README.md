<div id="top"></div>
<div align="center">
<h1>Bank Application API</h3>
  <p align="center">
    An ASP.NET Core Web API Application that returns a user's account balance and payment list.
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>

### Built With

* [.NET Core Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-5.0)
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

<p align="right">(<a href="#top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

*Visual Studio 2019 16.8 or later with the ASP.NET and web development workload
*.NET 5.0 SDK
 

### Installation

1. Get a free API Key at [https://example.com](https://example.com)
2. Clone the repo
   ```sh
   git clone https://github.com/github_username/repo_name.git
   ```
3. Install NPM packages
   ```sh
   npm install
   ```
4. Enter your API in `config.js`
   ```js
   const API_KEY = 'ENTER YOUR API';
   ```

<p align="right">(<a href="#top">back to top</a>)</p


<!-- USAGE EXAMPLES -->
## Usage

Image below is the list of existing data for users that we can use as reference for getting data for balance and payment list.
![bankApp_users_screenshot](https://user-images.githubusercontent.com/48245321/142574336-350ff20c-0dbc-4b65-a2b3-c144d63e6c9d.png)
  
Upon using the HTTP API GET: api/PaymentListItems/GetByUserId/{userId}, we will be able to get the payment list for that particular user
![bank-api-json](https://user-images.githubusercontent.com/48245321/142574332-b6f5fb29-0de2-4ba3-a4f6-9530baba00a6.png)

Using the GET: api/PaymentListItems would return all existing data for payment list
![bankApp_getAllPAymentList_screenshot](https://user-images.githubusercontent.com/48245321/142575203-69dd8978-5214-41aa-b32e-241da38fa054.png)
  
<p align="right">(<a href="#top">back to top</a>)</p>

## Contact

Hiroyuki Takada - hmtakada.cca@gmail.com

Project Link: https://github.com/htakada07/BankAppApi.git

<p align="right">(<a href="#top">back to top</a>)</p>
