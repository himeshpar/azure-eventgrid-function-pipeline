# Azure Event-Driven Function Pipeline  
### Blob Storage → Event Grid → Azure Functions (.NET 8 Isolated)

This project demonstrates a real-world, event-driven serverless workflow in Azure, using Blob Storage, Event Grid, and Azure Functions (.NET 8 Isolated) to automatically process uploaded files in real time.
It integrates **Blob Storage**, **Event Grid**, and an **Azure Function** to automatically process files the moment they are uploaded.

---

## 🚀 Architecture Overview

Blob Uploaded → Event Grid Detects Event → Azure Function Executes → Logs / Processing Output

1. A file is uploaded into **Azure Blob Storage**
2. **Azure Event Grid** detects the `BlobCreated` event
3. Event Grid calls the **ProcessTask** Azure Function
4. The function receives event metadata and executes custom logic

This architecture is cloud-native, scalable, and ideal for real-time automation scenarios.

---

## 🧱 Components Used

### **Azure Blob Storage**
- Stores input files  
- Generates events when blobs are created

### **Azure Event Grid**
- Event routing service  
- Subscribes to storage events  
- Sends events to the Azure Function

### **Azure Functions (.NET 8 Isolated)**
- Serverless compute  
- Triggered by Event Grid  
- Runs custom processing logic

### **Azure Function Core Tools**
- Used to publish and deploy the function from local development

---

## 📌 Why This Pattern Is Used in the Real World

Event-driven pipelines like this are widely used for:

- Processing user uploads  
- Automated ingestion of documents  
- Image or PDF analysis  
- Triggering downstream workflows  
- Integrating microservices  
- Real-time ETL and data pipelines  
- Reducing cost by eliminating polling and idle compute  

The serverless model means:
- **Pay only for execution time**
- **Automatic scaling**
- **Zero infrastructure to manage**

---

## 📂 Project Structure

/ProcessTaskFn
├── ProcessTask.cs # Azure Function triggered by Event Grid
├── Program.cs # Function host configuration
├── local.settings.json # Local dev settings (excluded from repo)
└── ...other .NET isolated function files

## 🔧 Deployment Steps

### **1. Create the Function App**
Used Azure Portal → Function App  
Runtime: **.NET 8 Isolated**  
Region: West Europe  
Plan: Consumption  

### **2. Add required configuration**
Inside Function App → Configuration:

AzureWebJobsStorage = <storage-connection-string>


### **3. Publish the Function (from local)**
func azure functionapp publish <your-function-app-name>


### **4. Create Event Grid Subscription**
Source: Blob Storage  
Event: Blob Created  
Endpoint Type: Azure Function  
Function: `ProcessTask`

---

## 📡 How to Test

1. Go to your Storage Account  
2. Create container (e.g., `input`)  
3. Upload any file  
4. Go to Azure Function → ProcessTask → **Monitor**  
5. You will see successful invocation logs  

---

## 📝 Example Log Output

Executed 'ProcessTask' (Succeeded)
Event Type: Microsoft.Storage.BlobCreated
Blob: /input/example.jpg

---

## 💼 About This Project

This repository is part of my Azure cloud engineering learning and demonstrates my ability to:

- Design event-driven serverless systems  
- Configure Event Grid system topics & subscriptions  
- Deploy Azure Functions using Core Tools  
- Work with Azure Storage, triggers, and bindings  
- Build production-style cloud automation  

## 🧠 Skills Demonstrated

- Azure Functions (C#, .NET 8 Isolated)
- Event-driven architecture
- Blob Storage event integration
- Event Grid subscriptions & system topics
- Deployment using Azure Functions Core Tools
- Cloud automation & serverless design
- Azure configuration & monitoring

Feel free to explore the code or reach out if you'd like to discuss Azure or serverless architectures!

---

## 📫 Contact

**Himesh Parmar**  
GitHub: https://github.com/himeshpar  
LinkedIn: https://www.linkedin.com/in/himesh-parmar-4067a9124/
