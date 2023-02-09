# Exercises

## Examine the docker-compose.yml folder
What are we starting?

## 1. Start Kafka
1. To start the kafka cluster, open this directory in a terminal
2. Use the 'docker-compose up' command to start kafka
3. This should start all kafka nodes and your cluster should be up and running, way to go!
4. Try to visit 'localhost:8088' to view a Kafka UI
5. Try to create a topic
6. Try to send a message to the topic


# Note: You can either choose to use the python or the .Net clients, both are implemented with the bare minimum functionality to interact with the kafka broker.


## 3. Publish 1 message per second, containing "{'test_key':'test_value'}"
1. Use the template for the producer to send your input to a kafka topic
2. Start the producer with the following commands: (assuming your terminal is located inside the producer directory)
   1. Build the docker image
      1. docker build . -t producer-client:latest
   2. run the docker image
      1. docker run --rm -it --network shared_network --name producer producer-client

## 5. Subscribe to the topic
1. Modify the subscriber template to subscribe to the topic where your producer publishes the messages
2. Start the consumer with the following commands (assuming your terminal is located inside the consumer directory)
   1. Build the docker image
      1. docker build . -t consumer-client:latest
   2. run the docker image
      1. docker run --rm -it --network shared_network --name consumer consumer-client

## 4. Change producer to read from a file and publish one line per second.
1. Modify the producer template to read alice-in-wonderland.txt file and publish the content one line at a time to a kafka topic.
2. modify it to publish 1 line per second. 

## 6. Write the received data in a file.
1. Modify the subscriber template to write the received data into a file called 'the-rabbit-hole.txt'