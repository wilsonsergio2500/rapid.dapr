<h1>
<img src="https://dapr.io/images/dapr.svg" width="50px">
Rapid Dapr
</h1>


Rapid Pub/Sub Approach to aid in getting started with Dapr and .NET

## The idea

Dapr is very prominent these days and it offers a very neat architecture for solving various challenges across 
distributed systems. In this repo, I provide a template that introduces a Pub/Sub model. The itent is to provide a guide but also to facilitate 
 getting started, and induce a good debugging experience instantly.

## Concept 
The code base introduces two main projects, the publisher and the subcriber. This naming convention is more
indicative of the Pub/Sub model and provides better first principle understanding of the overall architecture.

The publisher enables the publishing of an activity, the activity is simply a DTO that has a key and a value; 
where the value would represent the actual paylod and the key an enumeration item where we may classify the type of activity.

### Run The project

Utilize the Docker Compose Launch Settings to Run and provide debugging experience into the project.
Alternatively, in order to simply run via docker-compose 

```bash
docker-compose build
docker-compose up
```

### Trigger Publisher
In order to invoke the publisher call the below method via API

```bash
POST => /v1.0/invoke/publisherapp/method/publish
```

