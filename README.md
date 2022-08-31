
# TareasAPI

Simple API to manage your tasks! (Project done in the course "APIs con .NET" at Platzi) 😊


## Acknowledgements

 - [Curso de APIs con .NET](https://platzi.com/cursos/apis-net/)
 


## API Reference

#### Get all your tasks

```http
  GET /api/tarea
```
#### Get an specific task

```http
  GET /api/tarea/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of task to fetch |

#### Add a task

```http
  POST /api/tarea
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `CategoriaId`      | `string` | **Required**. Id of category to classify your tasks |
| `Titulo`      | `string` | **Required**. Name of the task |
| `Descipcion`      | `string` | Briefly describe your task |
| `PrioridadTarea`      | `string` | **Required**. Priority of the task |

#### Update a task

```http
  PUT /api/tarea/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of task to update |
| `CategoriaId`      | `string` | **Required**. Id of category to classify your tasks |
| `Titulo`      | `string` | **Required**. Name of the task |
| `Descipcion`      | `string` | Briefly describe your task |
| `PrioridadTarea`      | `string` | **Required**. Priority of the task |

#### Delete a task

```http
  GET /api/tarea/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of task to delete |

#### Get all categories

```http
  GET /api/categoria
```
#### Get an specific category

```http
  GET /api/categoria/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of category to fetch |

#### Add a task

```http
  POST /api/category
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Nombre`      | `string` | **Required**. Name of the category |
| `Descipcion`      | `string` | Briefly describe your category |
| `Peso`      | `string` | **Required**. Priority of the tasts on this category |

#### Update a category

```http
  PUT /api/categoria/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of category to update |
| `Nombre`      | `string` | **Required**. Name of the category |
| `Descipcion`      | `string` | Briefly describe your category |
| `Peso`      | `string` | **Required**. Priority of the tasts on this category |

#### Delete a category

```http
  GET /api/category/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of category to delete |
