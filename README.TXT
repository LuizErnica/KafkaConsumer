Kafka Docker Image Usage Guide:
	https://github.com/apache/kafka/blob/trunk/docker/examples/README.md

docker run -d --name broker apache/kafka:latest

docker exec --workdir /opt/kafka/bin/ -it broker sh

./kafka-topics.sh --bootstrap-server localhost:9092 --create --topic test-topic

docker rm -f broker



For External clients:

docker run -d -p 9092:9092 --name broker apache/kafka:latest

PS C:\> netstat -an | findstr 9092
