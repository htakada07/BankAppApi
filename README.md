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

1. Clone the repo
```sh
git clone https://github.com/htakada07/BankAppApi.git
```

### Prerequisites

*Visual Studio 2019 16.8 or later with the ASP.NET and web development workload
*.NET 5.0 SDK
 

### Installation

1. Build the project and run

  The launch URL is 
  ```
  https://localhost:<port number>/api/PaymentListItems/ 
  ```
  which shows all the payment list items.
  ```
  https://localhost:<port number>/api/PaymentListItems/GetByUserId/{userId} 
  ```
  would return a specific user’s payment list item which is ordered by date.

<p align="right">(<a href="#top">back to top</a>)</p


<!-- USAGE EXAMPLES -->
## Usage
  
Landing page is the SWAGGER UI
![bankapp_swaggerUI](https://user-images.githubusercontent.com/48245321/142602346-5538562b-bfff-48cc-b711-f557c8acb4be.png)
  
Image below is the endpoint for getting all the list of payments. (GET: api/PaymentListItems)
![bankapp_swaggerUI_getAll](https://user-images.githubusercontent.com/48245321/142602434-c8bc2fbb-8760-4404-ab89-8e134a5556d5.png)

Image below is the endpoint for gettiing the list of payments for a specific user (GET: api/PaymentListItems/GetByUserId/{userId})
![bankApp_swaggerUI_getByUserId](https://user-images.githubusercontent.com/48245321/142602745-2a8677c8-24ec-4df1-9058-30e401207a2d.png)

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
