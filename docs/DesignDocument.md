# SmartTask Design Document

## Overview
SmartTask is a simple task management system designed to demonstrate software design patterns.

## Patterns Used

### Singleton Pattern
TaskManager ensures only one instance exists.

### Strategy Pattern
Different storage strategies can be used (JSON, File, etc.).

### Factory Pattern
StorageFactory creates storage objects dynamically.

### MVC Concept
- Model: TaskItem
- Controller: TaskManager
- View: Console Interface