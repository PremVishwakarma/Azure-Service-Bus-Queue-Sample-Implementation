# Azure Queue Console Messaging Sample

A simple .NET console application demonstrating message communication between a Sender Console App and a Receiver Console App using Azure Queue Storage / Azure Messaging Queue.

This project is useful for beginners learning:

- Azure Queue Messaging
- Producer/Consumer Pattern
- Console Applications in .NET
- Asynchronous Messaging
- Azure SDK Integration

---

## Features

- Send messages from one console application
- Receive messages in another console application
- Simple and beginner-friendly implementation
- Easy Azure Queue setup

---

## Technologies Used

- .NET 8 / .NET 6
- C#
- Azure Queue Storage SDK

---

## Project Structure

```bash
SenderConsoleApp/
ReceiverConsoleApp/
```

---

## Prerequisites

Before running the application, make sure you have:

- An Azure Account
- An Azure Storage Account
- A Queue created inside Azure Storage

---

## Queue Name

Create a queue with the following name:

```bash
demosenderqueue
```

---

## Setup Instructions

### 1. Clone Repository

```bash
git clone https://github.com/yourusername/azure-queue-console-messaging-sample.git
```

---

### 2. Install Required Packages

Install Azure Queue package:

```bash
dotnet add package Azure.Storage.Queues
```

---

### 3. Configure Azure Connection String

Open the sender and receiver console applications and replace:

```csharp
string connectionString = "YOUR_AZURE_CONNECTION_STRING";
```

with your own Azure Storage connection string.

---

## How to Get Azure Connection String

1. Go to Azure Portal
2. Open your Storage Account
3. Navigate to:

```bash
Security + networking -> Access keys
```

4. Copy the connection string

---

## Running the Application

### Start Receiver Application First

```bash
dotnet run
```

Receiver will start listening for messages.

---

### Start Sender Application

```bash
dotnet run
```

Type messages in sender console.

---

## Example

### Sender

```bash
Enter Message:
Hello Azure Queue
```

### Receiver

```bash
Received Message:
Hello Azure Queue
```

---

## Important Notes

- Ensure both applications use the same queue name.
- Queue name must be:

```bash
demosenderqueue
```

- Replace the Azure connection string before running.
- Do not commit your real Azure connection string to GitHub.

---

## Security Warning

Never expose your Azure connection string publicly.

Use:

- Environment Variables
- Azure Key Vault
- User Secrets

for production applications.

---

## Future Improvements

- Retry mechanism
- Dead-letter queue support
- Logging
- Docker support
- Hosted background service
- ASP.NET Core integration

---

## Contributing

Contributions are welcome.

Please create a pull request or open an issue.

---

## License

This project is licensed under the MIT License.

---

## Author

Developed by Prem Vishwakarma
