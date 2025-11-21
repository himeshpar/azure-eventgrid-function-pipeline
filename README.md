# Azure Event-Driven Function Pipeline  
### Blob Storage → Event Grid → Azure Functions (.NET 8 Isolated)

This project demonstrates a fully serverless, event-driven workflow built in Microsoft Azure.  
It integrates **Blob Storage**, **Event Grid**, and an **Azure Function** to automatically process files the moment they are uploaded.

---

## 🚀 Architecture Overview

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

