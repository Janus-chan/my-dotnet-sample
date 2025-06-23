# Enhanced .NET Application with CI/CD

A comprehensive .NET console application demonstrating an advanced calculator with extensive functionality, selective unit testing coverage, and GitHub Actions CI/CD pipeline.

## Project Structure

```
dotnet-sample/
├── .github/
│   └── workflows/
│       └── ci-cd.yml          # GitHub Actions CI/CD pipeline
├── SampleApp/
│   ├── Calculator.cs          # Enhanced calculator with 20+ methods
│   ├── Program.cs             # Application entry point
│   └── SampleApp.csproj       # Project file
├── SampleApp.Tests/
│   ├── UnitTest1.cs           # Selective unit tests (52 tests)
│   └── SampleApp.Tests.csproj # Test project file
├── SampleApp.sln              # Solution file
└── README.md                  # This file
```

## Enhanced Features

### Basic Calculator Operations
- **Arithmetic**: Addition, Subtraction, Multiplication, Division
- **Error Handling**: Division by zero protection

### Advanced Mathematical Operations
- **Power**: Exponentiation calculations
- **Square Root**: With negative number validation
- **Factorial**: With comprehensive bounds checking

### Number Theory Functions
- **GCD**: Greatest Common Divisor using Euclidean algorithm
- **LCM**: Least Common Multiple calculation
- **Prime Testing**: Efficient prime number detection
- **Even/Odd**: Number parity checking
- **Fibonacci**: Sequence generation with configurable length

### Statistical Analysis
- **Average**: Mean calculation for number arrays
- **Median**: Middle value determination
- **Min/Max**: Extremum finding
- **Percentage**: Ratio calculations

### Conversion Utilities
- **Temperature**: Celsius ↔ Fahrenheit conversion
- **Distance**: Miles ↔ Kilometers conversion

### Financial Calculations
- **Compound Interest**: Investment growth calculations

## Test Coverage Strategy

This project demonstrates **realistic testing practices** with **partial coverage** (~75-80%) rather than aiming for 100%:

### ✅ **Tested Methods** (52 tests)
- All basic operations (Add, Subtract, Multiply, Divide)
- Advanced math (Power, SquareRoot, GCD)
- Number theory (IsPrime, Fibonacci, Factorial)
- Statistics (Average, Median)
- Error conditions and edge cases
- Financial calculations

### ⚠️ **Intentionally Untested Methods**
- **Temperature conversions** (CelsiusToFahrenheit, FahrenheitToCelsius)
- **Distance conversions** (MilesToKilometers, KilometersToMiles)
- **Some statistics** (Min, Max methods)
- **LCM calculation**
- **Some error scenarios** in compound interest

This approach reflects real-world development where:
- Critical business logic is thoroughly tested
- Utility functions may have lighter testing
- Some edge cases are documented but not tested
- Testing effort is balanced with project priorities

## Getting Started

### Prerequisites
- [.NET 8.0 or 9.0 SDK](https://dotnet.microsoft.com/download)
- Git (for version control)

### Running the Application

1. **Clone the repository**:
   ```bash
   git clone <your-repo-url>
   cd dotnet-sample
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Build the solution**:
   ```bash
   dotnet build
   ```

4. **Run the application**:
   ```bash
   dotnet run --project SampleApp
   ```

5. **Run tests**:
   ```bash
   dotnet test
   ```

### Expected Output

When you run the application, you'll see:

```
Enhanced Calculator Application
===============================
=== Basic Operations ===
5 + 3 = 8
10 - 4 = 6
6 * 7 = 42
15 / 3 = 5

=== Advanced Math ===
2^8 = 256
√25 = 5
5! = 120

=== Number Theory ===
GCD(48, 18) = 6
LCM(12, 8) = 24
Is 17 prime? True
Is 15 even? False

=== Fibonacci Sequence (first 8) ===
[0, 1, 1, 2, 3, 5, 8, 13]

=== Statistics ===
Numbers: [10, 20, 30, 40, 50]
Average: 30.00
Max: 50
Min: 10

=== Percentage ===
25 out of 100 = 25%

=== Error Handling ===
Error: Cannot divide by zero
Error: Cannot calculate square root of negative number

Application completed successfully!
```

## GitHub Actions CI/CD Pipeline

The project includes a comprehensive CI/CD pipeline that runs on every push and pull request:

### 🔄 **Build and Test Job**
- **Multi-version testing**: Tests against .NET 8.0.x and 9.0.x
- **Dependency caching**: Speeds up builds by caching NuGet packages
- **Code coverage**: Collects test coverage data
- **Artifact creation**: Uploads build artifacts and test results

### 🚀 **Release Job** (main branch only)
- **Multi-platform publishing**: Creates binaries for Windows, Linux, and macOS
- **Self-contained deployments**: No .NET runtime required on target machines
- **Compressed archives**: Creates `.tar.gz` and `.zip` files for distribution

### 🔒 **Security Scan Job**
- **Vulnerability checking**: Scans for known security issues in dependencies
- **Audit reporting**: Uploads security scan results as artifacts

### Workflow Triggers
- **Push**: Runs on `main` and `develop` branches
- **Pull Request**: Runs on PRs targeting `main` branch

### Artifacts Created
1. **Published Applications**: Cross-platform executables
2. **Test Results**: Coverage reports and test outputs
3. **Release Packages**: Distribution-ready archives
4. **Security Reports**: Vulnerability scan results

## Development

### Adding New Features
1. Add functionality to `Calculator.cs`
2. Decide on testing strategy (critical vs utility functions)
3. Add corresponding tests to `UnitTest1.cs` (if needed)
4. Run tests locally: `dotnet test`
5. Push changes to trigger CI/CD pipeline

### Testing Philosophy
- **Critical Business Logic**: 100% test coverage
- **Utility Functions**: Basic happy path testing
- **Error Conditions**: Test for expected exceptions
- **Edge Cases**: Document but may not test all scenarios

### Test Categories
- **Unit Tests**: Individual method testing with AAA pattern
- **Theory Tests**: Multiple input scenarios using `[InlineData]`
- **Exception Tests**: Error condition handling validation
- **Integration Tests**: Cross-method functionality (limited)

## Project Configuration

### Dependencies
- **.NET Runtime**: 9.0 (latest)
- **Test Framework**: xUnit 2.8.2
- **Coverage**: XPlat Code Coverage
- **LINQ**: For statistics operations

### Build Configurations
- **Debug**: Local development with debugging symbols
- **Release**: Optimized builds for production

## Test Metrics

✅ **52 Test Cases** covering core functionality  
⚡ **Multiple Test Types**: Unit, Theory, Exception tests  
🎯 **Selective Coverage**: ~75-80% (realistic approach)  
🔍 **Quality Focus**: Critical paths thoroughly tested  
📊 **Performance**: Fast test execution (<1 second)  

## Continuous Integration Benefits

✅ **Automated Testing**: Every change is automatically tested  
✅ **Multi-Platform Support**: Ensures compatibility across operating systems  
✅ **Quality Assurance**: Code coverage and security scanning  
✅ **Easy Deployment**: Ready-to-use artifacts for distribution  
✅ **Version Matrix**: Tests against multiple .NET versions  

## Contributing

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/new-feature`
3. Make your changes and add appropriate tests
4. Ensure tests pass: `dotnet test`
5. Consider the testing strategy for your changes
6. Commit your changes: `git commit -m 'Add new feature'`
7. Push to the branch: `git push origin feature/new-feature`
8. Submit a pull request

## License

This project is created for demonstration purposes. Feel free to use it as a template for your own .NET projects with GitHub Actions CI/CD. 