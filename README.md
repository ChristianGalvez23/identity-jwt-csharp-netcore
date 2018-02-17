# IdentityWebApi

# Introduction
I am demostrating how to use Identity Management and JWT in C# ASP.NET Core

# Overview
To run this project you must creat the database with name "identitywebapi". If you want to change the name you should modify the appsettings.json

# Authentication
If you don't have credentials, so you have to create it using the register method and if you have already credentials you have to use login method. Both methods, register and login, return a token that you can use to request the "protected method".

# Error Codes
You can get 401 status code, this means that the token is invalid or expired in case you did something wrong.

# Rate limit
I have not established request limits so be carefully.
