
# Projeto teste utilizando RabbitMQ + .NET 5

Projeto teste utilizando uma API como producer e um console application como consumidor.

ControladorFaturamento API:
https://github.com/viniciustg/ControladorFaturamento


## Instalação

rabbitmq-server no docker

```bash
docker run -d --hostname rabbit-server --name some-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management
```
    
Rodar a interface do rabbitmq em:

```bash
http://localhost:15672/
```
