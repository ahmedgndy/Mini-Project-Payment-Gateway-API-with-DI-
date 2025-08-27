Payment API – Minimal API with DI Lifetimes

This project is a .NET Minimal API that demonstrates:

Using Dependency Injection (DI) with different lifetimes (Transient, Scoped, Singleton).

A Payment Factory Pattern to switch between payment providers (PayPal, Stripe, Fake).

Environment–based service registration (Development vs Production).

🚀 How to Run

Clone the repo.

Restore dependencies:

dotnet restore


Run the project:

dotnet run


The API will be available at:

http://localhost:5129

📌 Endpoints
1. Process Payment

POST /pay/{provider}/{amount}

Example Requests
### PayPal Payment
POST http://localhost:5129/pay/paypal/100

### Visa Payment
POST http://localhost:5129/pay/visa/200

### Fake Provider (for testing)
POST http://localhost:5129/pay/fake/300

Example Response
{
  "status": "Success",
  "provider": "PayPal",
  "amount": 100,
  "transactionId": "f73e734c-6624-4cec-b5ef-482d282700ae",
  "message": "Payment processed successfully."
}

Example Error Response
{
  "error": "Payment Provider Not Supported"
}

2. Dependency Injection Lifetimes

GET /di/lifetimes

Shows GUIDs for each service lifetime (Transient, Scoped, Singleton).

Example Request
GET http://localhost:5129/di/lifetimes

Example Response
{
  "transient": "2a09bbe7-be97-40dd-9b12-09c565261cad",
  "scoped": "8f7a63e2-1886-455d-80b0-2f1fd42b7b5a",
  "singleton": "62d7b4cd-ff8a-4f6d-9cb9-9e1e6cdadd11"
}

🛠️ Tech Stack

.NET 7/8 Minimal API

Dependency Injection (Transient, Scoped, Singleton)

Factory Pattern

Environment–based configuration

📖 Notes

FakePaymentService is registered only in Development.

In Production, only real providers (PayPal, Stripe) are registered.

Lifetimes are demonstrated with unique GUIDs.
