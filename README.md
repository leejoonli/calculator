# Calculator in C#

## Application Description

This application is a calculator created using Visual Studio 2022 and the windows form app base application template.  The goal is to get more experience coding in C# and to build an application that has similar functionality as the calculator application built in to computers.

## Technologies Used

- C#

## Installation

Currently must have Microsoft Visual Studio installed and have Git commands available.

1. Open your terminal and navigate to your desired directory where you want to store this repository using `cd <YOUR DIRECTORY HERE>`.
2. On the GitHub repository, click on the "Code" dropdown menu and either click on "HTTPS" or "SSH" depending on what you're using.
    * You can either click the link which will highlight the github or https link and copy it or click on the icon next to the link which will copy it into your clipboard.
3. Fork and clone or just clone this repository to your machine using `git clone <PASTE SSH OR HTTPS HERE>`.
4. `cd` into the newly created directory.
5. Open the directory using Microsoft Visual Studio.
6. Launch the application using `Ctrl + F5`.
    * Your commands may vary depending on your operating system.  For more information please visit `https://docs.microsoft.com/en-us/visualstudio/mac/keyboard-shortcuts?view=vsmac-2022`.

## Current Application State

![image](https://user-images.githubusercontent.com/65789692/185300016-5fd9c59d-6087-40e4-8dc5-0d5974d0e56e.png)
![image](https://user-images.githubusercontent.com/65789692/185300029-ae8ca9b3-44ac-4f15-9235-68abc73c8e8a.png)
![image](https://user-images.githubusercontent.com/65789692/185300043-97339b29-0c65-401a-8521-5e0cbccf17a2.png)

## User Stories

- As a user, I want to be able to click buttons and have them display the numbers I press.
- As a user, I want the calculator to be able to make basic mathematical operations.
- As a user, I want to have the same or similar functionality as a standard calculator.

## Future Improvements

- Currently, the delete button does not work.  Will have to redo the logic behind displaying the numbers.
- Implement the same or similar functionality of a scientific calculator.
- Deploy application, maybe?

## Known Problems

- There is a bug using the decimal where if you don't have a number before the decimal (ex: `.1`), then the decimal disappears in the calculation.
- There is a bug when there is a calculation done that has decimals, there is a rounding error and will throw off any precise calculations.
- The delete button does not work.

# Contribution Guidelines

## How to Identify Bugs

> If you identify bugs, submit an issue on the Git repo. Please detail the bug in your issue. If you know how to fix it, feel free to note the methods you would use. You could also submit a pull request with suggested code to fix it.