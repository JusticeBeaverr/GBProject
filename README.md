# GadgetBlitz
Welcome to GadgetBlitz! This is a comprehensive documentation guide that will provide you with all the necessary information about the project.

## Introduction
GadgetBlitz is a web application designed to serve as a platform for **browsing** and **comparing mobile phones**. The application enables users to find detailed information about various phone models and make informed decisions based on their specific requirements. Whether you are a tech enthusiast, a consumer looking to purchase a new phone, or simply curious about the latest mobile technology, GadgetBlitz provides an intuitive and user-friendly interface to explore the vast world of smartphones.

The project consists of two main components: a Java-based backend developed using the **Spring Boot** framework and a frontend built with **.NET** utilizing the Blazorise platform. The backend is responsible for handling data management, processing user requests, and interacting with the database, while the frontend provides an interactive and visually appealing user interface for seamless navigation and comparison of phones.

## Features
GadgetBlitz offers a range of powerful features to enhance the user experience and assist in finding the perfect phone:

- ***Phone Browser:*** Users can browse through an extensive collection of phones, searching for specific models or exploring different brands and specifications.

- ***Phone Details:*** Each phone listing provides comprehensive details about the device, including specifications such as display size, camera capabilities, battery life, operating system, and more. Users can make an informed decision based on these specifications.

- ***Phone Comparison:*** GadgetBlitz allows users to compare multiple phones side by side, facilitating a detailed analysis of their specifications and helping users choose the best-suited device for their needs.

- ***Advanced Filtering:*** Users can utilize advanced filters to narrow down their search results based on specific criteria such as brand, battery capacity, operating system, price range, and screen size.

- ***User Accounts:*** GadgetBlitz provides user account functionality, allowing users to create accounts, save favorite phones for later reference, and receive personalized recommendations based on their preferences.

## Installation
To install and set up GadgetBlitz locally, follow these steps:

1. Clone the repository: git clone [https://github.com/your-username/GadgetBlitz.git](https://github.com/szymon4711/GadgetBlitz)

2. Set up the backend using Docker:

    - Navigate to the cloned repository's directory: `cd GadgetBlitz`
    - Build the Docker image for the backend: `docker build -t gadgetblitz-backend . `
    - Run the Docker container for the backend: `docker run -p 8080:8080 gadgetblitz-backend`
    - The backend server will now be running on http://localhost:8080.
3. Set up the frontend:

    - Navigate to the frontend directory: `cd frontend`
    - Install the necessary packages using a package manager such as npm: npm install
    - Configure the backend API URL in the appropriate configuration file.
    - Start the frontend server: `npm run start`
    - The frontend application will be accessible in your browser at http://localhost:3000.

Make sure you have Docker installed and running on your system before proceeding with the backend setup using Docker.

## Usage
Once the installation process is complete and you have the application running locally, you can start exploring and utilizing its features:

- ***Browsing Phones:*** Use the search bar or filters to find specific phones or browse through different models. Click on a phone to view its detailed specifications.

- ***Phone Comparison:*** Select multiple phones using the "Add to Compare" button and click on the "Compare" button to view a side-by-side comparison of their specifications.

- ***Filtering:*** Utilize the advanced filters on the phone browsing page to refine your search results based on brand, battery capacity, operating system, price range, or screen size.

- ***User Accounts:*** Create an account to save favorite phones, personalize your experience, and receive tailored recommendations based on your preferences.

## Technologies Used
GadgetBlitz leverages the following technologies:

**Backend:**

Java
- Spring Boot
- Spring Data JPA
- MySQL (or any other supported database)
- Maven
- Docker

***Frontend:***

- .NET
- Blazorise
- HTML
- CSS
- JavaScript
- npm (Node Package Manager)

## Contributing
We welcome contributions to GadgetBlitz! If you would like to contribute, please follow these steps:

1. Fork the repository on GitHub.
2. Create a new branch from the main branch.
3. Make your desired changes, addressing any open issues or adding new features.
4. Test your changes thoroughly.
5. Commit and push your changes to your forked repository.
6. Submit a pull request to the main repository, clearly describing the changes you have made.

## Acknowledgements
We would like to express our gratitude to the following individuals for their contributions to the development of GadgetBlitz:

- Damian Kaniewski
- Mariusz Gamrat
- Magda Gazda

Thank you for your interest in GadgetBlitz. If you have any questions or encounter any issues, please feel free to reach out to us. Happy browsing!
