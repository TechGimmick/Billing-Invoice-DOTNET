# 🧾 Billing Invoice System - .NET C# (WinForms)

## 📌 Project Overview

The **Billing Invoice System** is a desktop application built using **.NET Framework (C#)** and **Windows Forms**. This application provides a simple and interactive way to simulate a billing process for retail use cases. It starts with a customer login screen and continues to a full-featured invoice generation form with live calculation features.

---

## 🖥️ Application Workflow

### 1️⃣ Login Page (Form1)
Users are first presented with a login form where they must enter:
- **Customer Name**
- **Customer Number**
- **Customer ID**

> This form helps personalize the billing process and enables simple user session handling.

---

### 2️⃣ Product Catalog and Billing (Form2)
After login, users are navigated to the billing screen with a product catalog. Features include:
- Four predefined products with unit prices
- Quantity selectors for each item
- Auto-calculation of totals per item based on quantity
- Overall total field
- Manual discount field
- Final grand total
- “Check Out” button for generating the bill

#### 🛍️ Products:
| Product                   | Unit Price (₹) |
|---------------------------|----------------|
| Samsung Tab A             | 2,000          |
| Universal Stylus Pen      | 1,000          |
| Spare Stylus Tips         | 1,500          |
| Protection Screen Android | 1,800          |

---

### 3️⃣ Finalization / Confirmation (Form3)
This form may handle confirmation, summary, or thank-you messaging post-checkout (optional based on your implementation).

---

## 🗂️ Folder Structure

BillingInvoice/
├── Billing Invoice.sln # Visual Studio Solution File
├── Billing Invoice.csproj # Project file
├── .gitattributes # Git metadata
├── .gitignore # Git ignore rules
├── README.md # Project documentation
│
├── Properties/
│ └── AssemblyInfo.cs # Assembly config
│
├── Resources/ # Images, icons (if used)
│
├── Program.cs # Application entry point
│
├── Form1.cs # Login form logic
├── Form1.Designer.cs # UI layout for login
├── Form1.resx # Resources for login form
│
├── Form2.cs # Billing screen logic
├── Form2.Designer.cs # UI layout for billing screen
├── Form2.resx # Resources for billing screen
│
├── Form3.cs # Final confirmation form (optional)
├── Form3.Designer.cs # UI layout for confirmation
├── Form3.resx # Resources for confirmation


---

## 💡 Features Summary

- ✔️ Customer login interface
- ✔️ Billing form with dynamic price calculation
- ✔️ Manual discount entry
- ✔️ Real-time grand total computation
- ✔️ Intuitive user interface with product selector
- ✔️ Modular form design using multiple WinForms screens

---

## 🛠️ Tech Stack

- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **IDE:** Visual Studio (Recommended)

---

## 🚀 How to Run

1. Open `Billing Invoice.sln` in **Visual Studio**.
2. Build the solution (`Ctrl + Shift + B`).
3. Run the application (`F5`).
4. Enter customer details on the **Login Page**.
5. Proceed to billing, adjust quantities, add discount if needed.
6. Click **Check Out** to finish the process.

---

## 🧩 Future Enhancements

- 🧾 Add invoice export (PDF/Print)
- 💽 Store transaction history in a database
- 🧮 Include tax (GST/VAT) support
- 🧑‍💼 Admin panel for dynamic product management

---

## 👨‍💻 Developed by

**TechGimmick**  
Empowering practical learning through mini-software solutions.

---

## 📄 License

This project is open-source and available under the **MIT License**.
