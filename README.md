
# DbMigrationProject

This project demonstrates database migration management using Entity Framework Core (EF Core) and manual SQL scripts. Below are instructions for setting up the project, executing migrations, rolling back changes, and reviewing the project structure.
The Manual migrations can be found int the branch `main-manual` whilst the EF migrations are found in the branch `main-ef`.

---

## Project Setup

### 1. SQL Server
An instance of Microsoft SQL Server should be running with the simple SQL Server authentication configured.

### 2. Clone the Repository
```bash
git clone [repository-link]
cd DbMigrationProject
```

### 3. Configure the Database
Create a "db_credentials.json" file for your database communication with the following schema: 
```json
{ 
    "Username": "[username]",
    "Password": "[password]"
}
```

### 4. Run Initial Migration
Apply the initial migration to set up the base tables:
```bash
dotnet ef database update --project DbMigrationProject
```

### 5. Start the Project
Confirm the database connection by running the project:
```bash
dotnet run
```

---

## Migrations Documentation

### Manual Migrations

For the manual part of this assignment, the database schema is created through SQL scripts, located in the `ManualMigrations` folder. Each SQL file corresponds to a specific database modification.

#### Applying Manual Migrations
1. **Navigate to the SQL Scripts Folder**:  
   Manual SQL scripts are located in the `ManualMigrations` directory. Each script file is named based on the changes it introduces.

2. **Execute the SQL Script**:  
   Open SQL Server Management Studio (SSMS) or another SQL client, connect to the target database, and run the desired scripts.

#### Example of a Manual Migration
- **Script**: `ManualMigrations/initial-setup.sql`  
  This script initializes key tables and their relationships as required for the project. These scripts should be executed if not using EF Core for migration management.
- **Script**: `ManualMigrations/add-categories`  
  This script adds the categories table and the relation between it and the products table.
- **Script**: `ManualMigrations/add-ratings.sql`  
  This adds the product ratings table and the relation to the products table. 

---

### EF Core Migrations

Entity Framework Core (EF Core) was used to manage automatic migrations. Each branch in the project repository represents a different migration milestone:

#### Migration Branches and Commands
1. **Initial Setup (`ef/initial-setup`)**:  
   Adds the `Product` table as part of the initial database structure.
   ```bash
   dotnet ef migrations add InitialSetup
   ```

2. **Add Categories (`ef/add-categories`)**:  
   Adds the `Category` table and links it to the `Product` table.
   ```bash
   dotnet ef migrations add AddCategories
   ```

3. **Add Ratings (`ef/add-ratings`)**:  
   Creates the `ProductRating` table, linking it to `Product` with the necessary relationships.
   ```bash
   dotnet ef migrations add AddRatings
   ```

The combined migrations are found in the `main-ef` branch.

#### Applying EF Core Migrations
To update the database to the latest migration:
```bash
dotnet ef database update
```
All migrations are stored in the `Migrations` folder and can be referenced individually if needed.

---

## Rollback Instructions

### Manual Migration Rollback
Each manual migration script has an associated rollback script in the `Rollback` folder.
Additionally, there is a rollback script that reverts all changes combined and deletes the whole database.

**Execute the Rollback Script**:  
   Run the appropriate script in SSMS to reverse manual changes.

### EF Core Migration Rollback
EF Core allows rollbacks using the `dotnet ef database update` command and specifying a target migration.

#### Steps to Roll Back EF Core Migrations
1. **List Available Migrations**:
   ```bash
   dotnet ef migrations list
   ```

2. **Rollback to a Specific Migration**:
   Use the following command to rollback to a specified migration:
   ```bash
   dotnet ef database update <MigrationName>
   ```
   Example:
   ```bash
   dotnet ef database update InitialSetup
   ```

3. **Rollback All Migrations**:  
   To remove all EF Core migrations:
   ```bash
   dotnet ef database update 0
   ```
   This reverts the database to its original state.
