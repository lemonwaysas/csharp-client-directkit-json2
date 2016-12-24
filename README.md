# LemonWay [.NET Core](https://www.microsoft.com/net/core) tutorial

This is a console application developed and tested on a Linux machine using the [.NET Core platform](https://www.microsoft.com/net/core).

It calls the [GetWalletDetails service](http://documentation.lemonway.fr/api-en/directkit/manage-wallets/getwalletdetails-getting-detailed-wallet-data)
and display the details information of the wallet `sc`.

# How to run

1. Edit the `LwService.cs`. Put your `DIRECTKIT_URL` (json2), `LOGIN` and `PASSWORD`
2. Run the example:
```
dotnet run
```

# Time to play!

The example is only the basic, you can play with our API by calling other services. For example:
- [Create a new wallet](http://documentation.lemonway.fr/api-en/directkit/manage-wallets/registerwallet-creating-a-new-wallet)
- [Credit the wallet](http://documentation.lemonway.fr/api-en/directkit/money-in-credit-a-wallet/by-card/moneyin-credit-a-wallet-with-a-non-3d-secure-card-payment)
- [Register a Credit card to the wallet](http://documentation.lemonway.fr/api-en/directkit/money-in-credit-a-wallet/by-card/registercard-linking-a-card-number-to-a-wallet-for-one-click-payment-or-rebill)
- [Register an IBAN to the wallet](http://documentation.lemonway.fr/api-en/directkit/money-out-debit-a-wallet-and-credit-a-bank-account/registeriban-link-an-iban-to-a-wallet)
- [Transfer money from wallet to a bank account](http://documentation.lemonway.fr/api-en/directkit/money-out-debit-a-wallet-and-credit-a-bank-account/moneyout-external-fund-transfer-from-a-wallet-to-a-bank-account)
- [Transfer money from wallet to other wallet](http://documentation.lemonway.fr/api-en/directkit/p2p-transfer-between-wallets/sendpayment-on-us-payment-between-wallets)
- [Create a payment form to credit a wallet](http://documentation.lemonway.fr/api-en/directkit/money-in-credit-a-wallet/payment-form)

# Side notes

* You can only call the LemonWay service from your server which has been whitelisted.
* It is not the only way to access to our API, feel free to use your own library.