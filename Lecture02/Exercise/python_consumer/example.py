from kafka import KafkaConsumer
# The first argument is the topic name, the second is the bootstrap server of the Kafka cluster
# The third argument is the group id, which is used to identify the consumer group
consumer = KafkaConsumer('foobar', bootstrap_servers=['kafka1:9092'], group_id='group1')

for msg in consumer:
    print (msg.value.decode('utf-8'))