using System;
using System.IO;

namespace com.lemonway.tutorial {
	public class Program {
		/*
		This example call the GetWalletDetails service to display the wallet information
		http://documentation.lemonway.fr/api-en/directkit/manage-wallets/getwalletdetails-getting-detailed-wallet-data
		*/
		public static void GetWalletDetailsExample () {
			const string walletExtId = "sc";

			var request = LwService.CreateEmptyRequest ();
			request.Set ("wallet", walletExtId);
			var response = LwService.Call ("GetWalletDetails", request).d;

			//check if the GetWalletDetails service return error
			var err = response["E"];
			if (err.HasValues) {
				Console.Error.WriteLine ($"GetWalletDetails failed: error {err["Code"]} - {err["Msg"]}");
				return;
			}
			Console.WriteLine ("GetWalletDetails success. The wallet info is: ");
			Console.WriteLine (response);
		}

		public static void UploadFileExample () {
			const string walletExtId = "8888";

			var request = LwService.CreateEmptyRequest ();
			request.Set ("wallet", walletExtId);
			request.Set ("fileName", "logo.jpg");
			request.Set ("type", "4");
			request.Set ("buffer", System.Convert.ToBase64String (File.ReadAllBytes ("./test.jpg")));
			var response = LwService.Call ("UploadFile", request).d;

			//check if the UploadFile service return error
			var err = response["E"];
			if (err.HasValues) {
				Console.Error.WriteLine ($"UploadFile failed: error {err["Code"]} - {err["Msg"]}");
				return;
			}
			Console.WriteLine ("UploadFile success: ");
			Console.WriteLine (response);
		}

		public static void Main (string[] args) {
			Console.WriteLine ("---- Application start -----------");
			try {
				GetWalletDetailsExample ();
			} catch (Exception ex) {
				Console.WriteLine (ex);
			}
			Console.WriteLine ("---- Application end -------------");
		}
	}
}