# Payment API – Minimal API with DI Lifetimes

This project is a **.NET Minimal API** that demonstrates key software engineering concepts including **Dependency Injection (DI)** and the **Factory Pattern**. It's designed to handle payment processing for different providers, with a focus on showcasing different service lifetimes and environment-specific configuration.

---

### 🚀 How to Run

To get the project up and running on your local machine, follow these steps:

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/your-username/your-repo-name.git](https://github.com/your-username/your-repo-name.git)
    cd your-repo-name
    ```

2.  **Restore dependencies:**
    ```bash
    dotnet restore
    ```

3.  **Run the project:**
    ```bash
    dotnet run
    ```

The API will be available at `http://localhost:5129`.

---

### 📌 Endpoints

The API provides two main endpoints for demonstration.

#### **Process Payment**
This endpoint processes a payment using a specified provider and amount. It uses the **Factory Pattern** to dynamically select the correct payment service.

* **URL:** `POST /pay/{provider}/{amount}`

* **Example Requests:**
    * **PayPal Payment:** `POST http://localhost:5129/pay/paypal/100`
    * **Visa Payment:** `POST http://localhost:5129/pay/visa/200`
    * **Fake Provider (for testing):** `POST http://localhost:5129/pay/fake/300`

* **Example Response (Success):**
    ```json
    {
      "status": "Success",
      "provider": "PayPal",
      "amount": 100,
      "transactionId": "f73e734c-6624-4cec-b5ef-482d282700ae",
      "message": "Payment processed successfully."
    }
    ```

* **Example Response (Error):**
    ```json
    {
      "error": "Payment Provider Not Supported"
    }
    ```

#### **Dependency Injection Lifetimes**
This endpoint demonstrates the different **DI lifetimes** (Transient, Scoped, and Singleton) by returning unique **GUIDs** for each service. This helps visualize how each lifetime manages a service instance.

* **URL:** `GET /di/lifetimes`

* **Example Response:**
    ```json
    {
      "transient": "2a09bbe7-be97-40dd-9b12-09c565261cad",
      "scoped": "8f7a63e2-1886-455d-80b0-2f1fd42b7b5a",
      "singleton": "62d7b4cd-ff8a-4f6d-9cb9-9e1e6cdadd11"
    }
    ```

---

### 🛠️ Tech Stack

* **Backend:** .NET 7/8 Minimal API
* **Concepts:** Dependency Injection (Transient, Scoped, Singleton)
* **Design Pattern:** Factory Pattern
* **Configuration:** Environment-based configuration

---

### 📖 Notes

* **Environment-based Registration:** The `FakePaymentService` is only registered and available when the application is running in the **Development** environment.
* **Production Configuration:** In the **Production** environment, only the real payment providers (PayPal, Stripe) are registered and accessible.
* **Lifetime Demonstration:** The `/di/lifetimes` endpoint uses unique **GUIDs** to clearly illustrate the behavior of each service lifetime:
    * A **transient** service creates a new instance for every request.
    * A **scoped** service creates one instance per client request.
    * A **singleton** service creates only one instance for the entire application's lifetime.

 
