# Kafka Consumer (.NET)

> A simple .NET application demonstrating how to consume messages from an Apache Kafka topic using a Kafka Consumer.

## 📚 About the Project

This project is a practical example of implementing a **Kafka Consumer** using **.NET** and **C#**.

Its primary goal is to demonstrate how to connect to an Apache Kafka broker, subscribe to a topic, receive messages, and understand the fundamentals of event-driven communication.

This repository is intended for educational purposes and serves as a starting point for developers learning Apache Kafka integration with .NET applications.

---

## 🚀 Technologies

- .NET
- C#
- Apache Kafka
- Docker
- Confluent.Kafka (.NET Client)

---

## ✨ Features

- Connect to an Apache Kafka broker
- Subscribe to Kafka topics
- Consume messages continuously
- Configurable broker address
- Consumer Group support
- Graceful shutdown
- Educational and easy-to-understand implementation
- Docker-based Kafka setup

---

## 📂 Project Structure

```text
KafkaConsumer
│
├── Program.cs
├── appsettings.json
├── Properties/
├── README.md
└── KafkaConsumer.csproj
```

> *The structure may evolve as new features are added.*

---

## 🎯 Objectives

- Learn the fundamentals of Apache Kafka
- Understand the Consumer role in Kafka
- Consume messages using .NET
- Learn how Consumer Groups work
- Practice event-driven application development

---

## ▶️ Getting Started

### Clone the repository

```bash
git clone https://github.com/LuizErnica/KafkaConsumer.git
```

### Navigate to the project

```bash
cd KafkaConsumer
```

### Restore dependencies

```bash
dotnet restore
```

### Run the application

```bash
dotnet run
```

---

# 🐳 Running Kafka with Docker

Kafka provides an official Docker image that can be used for local development.

**Kafka Docker Image Usage Guide**

https://github.com/apache/kafka/blob/trunk/docker/examples/README.md

### Start a Kafka broker

```bash
docker run -d --name broker apache/kafka:latest
```

### Access the container

```bash
docker exec --workdir /opt/kafka/bin/ -it broker sh
```

### Create a topic

```bash
./kafka-topics.sh \
  --bootstrap-server localhost:9092 \
  --create \
  --topic test-topic
```

### Remove the broker

```bash
docker rm -f broker
```

---

## 🌐 Allow External Clients to Connect

Run Kafka exposing port **9092**:

```bash
docker run -d -p 9092:9092 --name broker apache/kafka:latest
```

Verify that the port is listening (Windows):

```powershell
netstat -an | findstr 9092
```

---

## 📖 Concepts Covered

- Apache Kafka
- Kafka Consumer
- Consumer Groups
- Topics
- Brokers
- Message Consumption
- Offset Management
- Event-Driven Architecture
- Docker
- Asynchronous Programming

---

## 💡 Learning Outcomes

By exploring this project, you will learn how to:

- Configure a Kafka Consumer in .NET
- Connect to a Kafka broker
- Subscribe to Kafka topics
- Consume messages continuously
- Understand Consumer Groups and offset management
- Run Kafka locally with Docker
- Build event-driven applications using Kafka

---

## 🔄 Producer–Consumer Workflow

```text
+-----------------+        +------------------+        +------------------+
| Kafka Producer  | -----> |   Kafka Broker   | -----> | Kafka Consumer   |
+-----------------+        +------------------+        +------------------+
         |                         |                            |
    Send Messages             Store Messages              Read Messages
```

---

## 📚 References

- Apache Kafka Documentation
- Confluent.Kafka .NET Client
- Microsoft Learn — .NET
- Docker Documentation

---

## 👨‍💻 Author

**Luiz Henrique Érnica**

GitHub: https://github.com/LuizErnica

---

## 📄 License

This project was created for educational and learning purposes.
