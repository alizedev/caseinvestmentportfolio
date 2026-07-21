# 🎮 CS2 Case Investment Tracker

![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![C#](https://img.shields.io/badge/C%23-WPF-blue)
![Platform](https://img.shields.io/badge/Platform-Windows-informational)
![License](https://img.shields.io/badge/license-MIT-green)

A modern **C# WPF desktop application** for tracking **Counter-Strike 2 Case Investments**.

The application helps CS2 investors manage their case portfolio, track profits, monitor price changes and analyze investment performance.

---

# 📸 Preview

> Steam-inspired dark UI for managing CS2 case investments.

Features:

- 📦 Case portfolio management
- 💰 Investment tracking
- 📈 ROI calculation
- 📊 Price history
- 🔄 Steam Market price updates
- 📉 Profit/Loss analysis

---

# 🚀 Features

## 💼 Portfolio Management

- Add CS2 cases to your portfolio
- Track:
  - Buy price
  - Current price
  - Quantity
  - Total investment
  - Current value
  - Profit
  - ROI %

Example:

```
Case:
Revolution Case

Bought:
2900x @ 0.18€

Current:
2900 @ 0.40€

Profit:
+1.160 €

ROI:
+25%
```

---

# 📊 Dashboard

The main dashboard displays:

- Total invested money
- Current portfolio value
- Total profit
- ROI percentage
- Best performing cases
- Worst performing cases

---

# 📈 Price History

Track historical case prices.

Stored information:

```
Case Name
Date
Price
Market Volume
```

Example:

```
Gamma 2 Case

01.01.2026  1.80€
01.02.2026  2.10€
01.03.2026  2.14€
```

---

# 🌐 Steam Market Integration

The application can retrieve current CS2 case prices.

Supported:

- Steam Market price lookup
- Automatic price updates
- Market value calculation

---

# 🏗️ Project Structure

```
CaseInvestmentTracker

│
├── Models
│   ├── Case.cs
│   ├── PriceHistory.cs
│   └── SteamPriceResponse.cs
│
├── Services
│   ├── SteamService.cs
│   ├── PortfolioService.cs
│   └── PriceHistoryService.cs
│
├── ViewModels
│   └── MainViewModel.cs
│
├── Views
│   └── MainWindow.xaml
│
└── App.xaml
```

---

# 🛠️ Technologies

## Backend

- C#
- .NET 8
- LINQ
- JSON Serialization

## Frontend

- WPF
- XAML
- MVVM Pattern

## Planned

- SQLite Database
- LiveCharts2
- Steam Inventory Import
- CSFloat API
- Skinport API

---

# 📦 Installation

## Requirements

- Windows 10/11
- .NET 8 Runtime
- Visual Studio 2022/2026 or JetBrains Rider


## Clone Repository

```bash
git clone https://github.com/yourusername/CS2-Case-Investment-Tracker.git
```

---

## Start Application

Open:

```
CaseInvestmentTracker.sln
```

Build:

```
CTRL + SHIFT + B
```

Run:

```
F5
```

---

# 📂 Example Portfolio

```csharp
Cases.Add(new Case
{
    Name = "Operation Breakout Weapon Case",
    BuyPrice = 2.30m,
    CurrentPrice = 8.45m,
    Quantity = 50
});
```

Output:

```
Investment:
2900€

Current Value:
4000€

Profit:
+1100€

ROI:
+37,9 %
```

---

# 🔮 Roadmap

## Version 1.0

✅ Portfolio tracking  
✅ ROI calculation  
✅ Steam price lookup  
✅ WPF Dashboard  


## Version 1.5

⬜ SQLite database  
⬜ Price charts  
⬜ Automatic refresh  
⬜ Export CSV  


## Version 2.0

⬜ Steam Inventory Scanner  
⬜ CSFloat integration  
⬜ Market comparison  
⬜ Investment alerts  
⬜ Cloud sync  

---

# ⚠️ Disclaimer

This project is only a tracking and analysis tool.

It does not provide financial advice.

CS2 items are digital goods and prices can change significantly.

---

# 👤 Author

**AlizeDev**

GitHub:
https://github.com/alizedev

---

# 📄 License

MIT License
