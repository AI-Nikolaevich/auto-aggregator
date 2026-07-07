# Auto Aggregator

Scalable ASP.NET Core backend for aggregating vehicle listings from multiple marketplaces.

## Overview

Auto Aggregator is a backend application that collects vehicle listings from multiple marketplaces and provides a unified REST API for searching, filtering, and comparing offers.

## Goals

* Build a scalable and maintainable backend.
* Learn and apply modern .NET development practices.
* Demonstrate clean architecture and software design principles.
* Integrate multiple external data sources through independent adapters.

## Planned Features

* Unified vehicle search
* Marketplace adapters
* REST API
* JWT authentication
* Background synchronization
* Caching
* Vehicle comparison
* Favorites
* Swagger/OpenAPI documentation

## Technology Stack

* ASP.NET Core
* .NET 8
* Entity Framework Core
* PostgreSQL
* Docker
* Swagger
* Serilog

### Planned

* Redis
* RabbitMQ
* Hangfire
* xUnit
* FluentValidation

## Project Structure

```
src/
 ├── AutoAggregator.Api
 ├── AutoAggregator.Application
 ├── AutoAggregator.Domain
 ├── AutoAggregator.Infrastructure

tests/
 └── AutoAggregator.Tests
```

## Architecture

The project follows Clean Architecture principles with a clear separation between the Domain, Application, Infrastructure, and API layers.

## Roadmap

* [ ] Create solution structure
* [ ] Configure ASP.NET Core
* [ ] Configure PostgreSQL
* [ ] Implement Entity Framework Core
* [ ] Add authentication
* [ ] Implement marketplace adapters
* [ ] Add background synchronization
* [ ] Add Redis caching
* [ ] Add RabbitMQ messaging
* [ ] Add automated tests
* [ ] Deploy with Docker

## License

This project is created for educational and portfolio purposes.
