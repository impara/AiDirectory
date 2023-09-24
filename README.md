# AI Tools Directory - Blazor App

Welcome to the AI Tools Directory, a Blazor web application that provides a comprehensive list of AI tools. This application allows users to search, filter, and view details of various AI tools.

## Features

- **Search Bar**: Allows users to search for specific AI tools based on their names or other attributes.
- **Filters**: Provides filtering options based on pricing models, additional information, and more.
- **Pagination**: Supports pagination to navigate through the list of tools.
- **Tool Details**: Displays detailed information about a selected tool in a modal.
- **Dynamic Icons**: Displays category-specific icons for each tool.

## Components

- **ToolDetails**: A modal component that shows the details of a selected AI tool.
- **SearchBar**: A component that provides a search input field and a reset button for filters.
- **Filters**: A component that offers various filtering options.
- **Pagination**: A component that handles page navigation.

## How It Works

1. On initialization, the app fetches a list of AI tools.
2. Users can search for tools using the search bar.
3. Filters allow users to narrow down the list based on specific criteria.
4. Clicking on a tool opens the ToolDetails modal, providing more information about the selected tool.
5. Pagination controls help navigate through the list of tools.

## Error Handling

The application has error handling in place. If there's an issue fetching the tools, an error is logged using the `ILogger` service.

## Icons By Category

The app dynamically assigns icons based on the tool's category. For instance:
- Finance tools get a dollar sign icon.
- Productivity tools get a lightbulb icon.
- ... and so on.

## Getting Started

1. Clone the repository.
2. Ensure you have the necessary packages installed.
3. Run the application.

## Dependencies

- `AiDirectory.Data`: Contains the data models and API-related functionalities.
- `AiDirectory.Components`: Houses the various components used in the application.

## Contributing

Feel free to contribute to this project by opening issues or submitting pull requests.