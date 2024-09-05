# LibX Book Library

LibX Book Library is a modern web application built with Blazor and Entity Framework Core, designed to manage a comprehensive library of books. The application supports essential CRUD (Create, Read, Update, Delete) operations, allowing users to add, view, edit, and delete books seamlessly. With an intuitive user interface and robust backend, LibX ensures efficient book management for libraries, bookstores, or personal collections.

## Features

- **Book Management**
  - **Add New Books:** Easily add new books using a user-friendly popup form.
  - **View Books:** Display a comprehensive list of all books with essential details.
  - **Edit Books:** Update book information as needed.
  - **Delete Books:** Remove books from the library with a simple click.
- **Detailed Book Information**
  - Title, Subtitle, Author, Publisher, Edition, Page Count
  - Barcode, RFID, Shelf Location, Assigned To, Assigned Date
  - Member Info, Checkout Date, Return Date, Issued By Staff
  - Condition, Defects, Has Backup, Estimated Value, Category, Usage Type, Times Exchanged
- **User Authentication**
  - Secure user authentication and authorization using ASP.NET Core Identity.
- **Responsive Design**
  - Built with Blazor, ensuring a responsive and modern web interface.
- **Database Integration**
  - Utilize Entity Framework Core with SQL Server for reliable data management.
- **Validation**
  - Form validation to ensure data integrity when adding or editing books.

## Technologies Used

- **Blazor:** For building interactive web UI with C#.
- **Entity Framework Core:** ORM for database operations.
- **SQL Server:** Relational database management system.
- **ASP.NET Core Identity:** For user authentication and authorization.
- **C#:** Primary programming language for backend and frontend logic.
- **Bootstrap:** For responsive and modern UI design.

## Installation

### Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or any preferred IDE

### Steps

1. **Clone the Repository**

   ```bash
   git clone https://github.com/your-username/libx-book-library.git
   cd libx-book-library
   ```

2. **Restore Dependencies**

   Open the project in Visual Studio and restore NuGet packages, or use the .NET CLI:

   ```bash
   dotnet restore
   ```

3. **Configure the Database**

   - Open the `appsettings.json` file.
   - Update the `DefaultConnection` string with your SQL Server connection details.

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=LibXBookLibrary;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
   }
   ```

4. **Apply Migrations and Update the Database**

   Ensure you have the `Microsoft.EntityFrameworkCore.Tools` package installed. Then run:

   ```bash
   dotnet ef database update
   ```

   This will create the necessary database schema.

5. **Run the Application**

   Use Visual Studio to run the project with IIS Express or use the .NET CLI:

   ```bash
   dotnet run
   ```

   Navigate to `https://localhost:5001` (or the specified URL) to access the application.

## Usage

- **View Books:** Navigate to the `/Books` page to see a list of all books in the library.
- **Add a New Book:** Click the "Add New Book" button to open a popup form. Fill in the required details and submit to add the book to the library.
- **Edit a Book:** (Feature can be implemented similarly) Select a book from the list and choose to edit its details.
- **Delete a Book:** Click the "Delete" button next to a book to remove it from the library.
- **Authentication:** Register and log in to manage books securely.

## Contributing

Contributions are welcome! Please follow these steps to contribute:

1. **Fork the Repository**

   Click the "Fork" button at the top right of the repository page.

2. **Clone Your Fork**

   ```bash
   git clone https://github.com/your-username/libx-book-library.git
   cd libx-book-library
   ```

3. **Create a Branch**

   ```bash
   git checkout -b feature/YourFeatureName
   ```

4. **Make Your Changes**

   Implement your feature or bug fix.

5. **Commit Your Changes**

   ```bash
   git commit -m "Add feature: YourFeatureName"
   ```

6. **Push to Your Fork**

   ```bash
   git push origin feature/YourFeatureName
   ```

7. **Create a Pull Request**

   Go to the original repository and create a pull request from your fork.

## License

This project is licensed under the [MIT License](LICENSE).

## Contact

For any inquiries or feedback, please contact [your-email@example.com](mailto:your-email@example.com).

## Acknowledgements

- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [ASP.NET Core Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- [Bootstrap](https://getbootstrap.com/)
