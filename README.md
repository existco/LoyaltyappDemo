![Loyaltyapp logo](https://raw.githubusercontent.com/existco/LoyaltyappDemo/master/Documentation/images/LoyaltyappLogo.png)

# Loyalty app API Demo

Loyalty app API is a library for performing tight integration to the Loyaltyapp rewards program from a POS system.

## Contents

There are two folders in this repo:
* Documentation
* DemoApp

### Documentation

The "Documentation" folder holds the documentation on the API calls and classes used in the Loyalty app API and Layout libraries. Refer to this documentation to learn how to use the Loyalty app system to its fullest.

### DemoApp

The demo app demonstrates the functionality of the Loyaltyapp.Api and Loyaltyapp.Layout packages. It is intended to provide an example of integrating with the Loyalty app rewards ecosystem.

You can perform transactions, query transactions, verify user data, and generate vouchers from within the demo app.

# Usage

## Introduction

The Loyalty app SDK provides a sample application for testing the API calls and receipt generation options available.

![Demo app overview](https://raw.githubusercontent.com/existco/LoyaltyappDemo/master/Documentation/images/DemoApp1.png)

The first step in using the demo app is to log in with your Loyalty app merchant credentials. Fill out the details in the “Open/Close Session” box and click the “Log In” button.

There are three basic functions available from the demo app:
* Verify PIN
* Perform Transaction
* Search Transactions

The demo app will save your user details and current session when you log in or out. This data will be saved in your roaming user profile. This functionality is provided simply as a quality of life function and is not necessary in order to use the Loyalty app API.

## Verify PIN

![Verify PIN screenshot](https://raw.githubusercontent.com/existco/LoyaltyappDemo/master/Documentation/images/DemoApp2.png)

PIN verification is useful for a POS application to ensure the current operator is the same person currently logged in to the Loyalty app API.

Enter the current user’s PIN and click the “Verify PIN” button. The status display should change to show the PIN validation result.

## Perform Transaction

![Perform Transaction screenshot](https://raw.githubusercontent.com/existco/LoyaltyappDemo/master/Documentation/images/DemoApp3.png)

Transactions are the core of the Loyalty app API. The "Perform Transaction" tab allows you to test creating transactions, exploring transaction properties, and querying transaction statuses.

Using this tab, you may:
* Create a “pay with cash” transaction,
* Create a “pay with points” transaction,
* Create a “refund” transaction,
* Cancel a transaction,
* Generate a receipt/voucher for a transaction, and
* Check the status of a transaction

When creating a transaction, the "Transaction ID" field will be automatically filled out with the new transaction’s ID. Depending on which action is selected, you may need to provide a transaction ID and/or a dollar value to use.

Once a transaction is generated, the box to the right of the buttons will show a QR code for you to scan. You can also click “Generate Receipt” to generate a receipt/voucher and display it in the “Receipt View” tab. You may also click “Check Status” to query the transaction’s current status.

## Search Transactions

![Search Transaction screenshot](https://raw.githubusercontent.com/existco/LoyaltyappDemo/master/Documentation/images/DemoApp4.png)

The "Search Transactions" tab allows you to query Loyalty app for any past transactions.

To search for a transaction, enter the criteria using the dropdowns, checkboxes and date/time entries provided. Note the date/time entries are optional and can be enabled using the checkboxes next to the entries.

Once you have entered your search criteria, click the “Search” button to begin the search. Queries that return a lot of results may take several seconds to several minutes to complete. Try to limit your search parameters using the date range entries to reduce the number of records retrieved. 

# License

[MIT](https://choosealicense.com/licenses/mit/)