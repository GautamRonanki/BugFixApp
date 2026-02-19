---

**What did I do?**

**Handled Multiple Warnings Before Application Setup:**

- Tried to restore packages, which threw a warning indicating that `netcoreapp3.1` is out of support.
- Updated the target framework to `net8.0` in `Bugfixapp.csproj`.

**Use of `await` in Non-Async Method:**

- Ensured that the method using `await` is marked as `async` and its return type is `Task`.

**Missing `UseInMemoryDatabase` Extension Method:**

- Added the necessary package reference for `Microsoft.EntityFrameworkCore.InMemory` in `Bugfixapp.csproj`.

**Missing Primary Key Definition for `DbUserValue`:**

- Defined a composite primary key for the `DbUserValue` entity in `AppDbContext.cs`.

**NullReferenceException in Views:**

- Ensured that related entities are included and properly loaded.
- Added checks to ensure objects are not null before accessing their properties.

**Issues with Service Registration in `Startup.cs`:**

- Multiple issues occurred with services not being registered correctly in `Startup.cs`, causing the dependency injection system to be unable to resolve services.

Once all the issues and warnings were fixed, the application was up and running.

---

**The First Issue: Data Duplication**

Every time the application was restarted, the data (users and values) was getting duplicated because the `DatabaseInitializer` was seeding the data without checking if the data already existed in the database.

**Fix:**

- Added a check to see if the data already exists before seeding new data.

**NullReferenceException in Views**

A `NullReferenceException` was being thrown in the views, indicating that an object was being accessed without being properly initialized. The related entities (`UserValues` and `Values`) were not being included when querying the `User` entities, resulting in accessing null properties.

**Fix:**

- Included the related entities in the queries to ensure they are loaded and initialized properly.

**Issues with the View**

The view was displaying GUIDs instead of meaningful titles because the code was referencing GUIDs directly instead of the related entity properties.

**Fix:**

- Referenced related data and displayed titles instead of GUIDs.

---

**That's it.**

---
