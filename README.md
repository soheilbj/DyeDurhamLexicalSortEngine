# DyeDurhamLexicalSortEngine

A .NET 9 project structured with a multi-layer architecture, designed to implement a sorting  and related data management functionality.

---

## Project Structure

- **DyeDurhamLexicalSortEngine.Domain**  
  - Contains the core domain entities and models.  
  
- **DyeDurhamLexicalSortEngine.Infrastructure**  
  - Contains services, repositories, and data access components.  
  

- **DyeDurhamLexicalSortEngine.Console**  
  - A  console application to run the services and test its functionality.  
  
- **DyeDurhamLexicalSortEngine.Infrastructure.Tests**  
  - Contains unit tests for the infrastructure layer.  
  
---

## CI/CD Pipeline

This project is integrated with **AppVeyor** for continuous integration:

- Builds the main project and test projects automatically on push.  
[- Runs unit tests and publishes artifacts.  
- Example badge for build status:
](https://ci.appveyor.com/project/soheilbj/dyedurhamlexicalsortengine)
```markdown
