from operator import truediv
from kafka import KafkaProducer
# the bootstrap server is the address of the kafka broker, i.e. the docker container. Here you can specify multiple brokers 
# separated by a comma to enable load balancing and fault tolerance.producer = KafkaProducer(bootstrap_servers='kafka1:9092')
producer = KafkaProducer(bootstrap_servers='kafka1:9092')
exit = False
while not exit:
    msg = input("Enter a message: ")
    if(input == "exit"):
        exit == True
        break
    # send the message to the topic 'foobar'
    producer.send('foobar', msg.encode('utf-8'))
    producer.flush()