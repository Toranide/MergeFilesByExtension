# MergeFilesByExtension

> A lightweight Windows utility for merging source files by module and file extension.

MergeFilesByExtension scans the top-level folders of a project, groups related folders into modules, collects selected file types, and exports each module into a readable `.txt` file.

This is especially useful when you need to quickly package the source of a modular project for review, documentation, backup, or AI-assisted analysis.

![MergeFilesByExtension application](img/Merge%20Files%20by%20Extension%20App.png)

## Features

- Group files by module name.
- Select one or more file extensions, such as `cs, cshtml, json`.
- Exclude folders and files with a comma-separated block list.
- Automatically ignores common build and source-control folders: `bin`, `obj`, `.vs`, and `.git`.
- Choose a custom output folder.
- Keep the UI responsive during large merges.
- Cancel a running operation.
- See the current processing status.
- Continue when individual files cannot be read and report skipped items.
- Produce deterministic, readable module output.

## How it works

The tool expects a project layout where related top-level folders share a module prefix.

For example:

```text
MyProject/
├── Account.Application/
├── Account.Domain/
├── Account.Infrastructure/
├── Project.Application/
├── Project.Domain/
└── Task.Domain/
```

The generated output will be:

```text
Account.txt
Project.txt
Task.txt
```

Folders are grouped by the text before the first `.` in their top-level folder name. A folder named `Account.Domain` therefore belongs to the `Account` module.

## Usage

1. Select the root folder of your project.
2. Enter the file extensions you want to merge.

   Example:

   ```text
   cs, cshtml, json
   ```

3. Add any folders or files you want to exclude.

   Example:

   ```text
   Migrations, Tests, generated.cs
   ```

4. Choose the output folder.
5. Click **Start merge**.
6. Open the output folder when processing is complete.

Extensions can be entered with or without a leading dot. Matching is case-insensitive.

## Output format

Each module is exported to its own text file.

Example:

```text
==========================================================================================
MODULE: Task
FILES: 3
==========================================================================================

>>> Task.Domain/Entities/TaskItem.cs
--------------------------------------------------------------------------------
[file contents]
--------------------------------------------------------------------------------

>>> Task.Application/Commands/CreateTask.cs
--------------------------------------------------------------------------------
[file contents]
--------------------------------------------------------------------------------
```

Relative file paths are included so the original source location remains clear.

## Requirements

- Windows
- .NET Framework 4.8

The project is a classic Windows Forms application and targets .NET Framework 4.8.

## Build from source

Clone the repository and open `MergeFilesByExtension.sln` in Visual Studio with .NET Framework 4.8 development tools installed.

Then build the solution in **Release** configuration.

You can also build from a Visual Studio Developer PowerShell:

```powershell
msbuild MergeFilesByExtension.sln /p:Configuration=Release
```

The built executable will be available under:

```text
bin\Release\
```

## Project structure

```text
MergeFilesByExtension/
├── Models/
│   ├── MergeOptions.cs
│   └── MergeResult.cs
├── Services/
│   └── FileMergeService.cs
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── MergeFilesByExtension.sln
```

The merge engine is separated from the WinForms UI so the file-processing logic remains easier to maintain and extend.

## Contributing

Bug reports, feature ideas, and pull requests are welcome.

Please use the GitHub issue templates when reporting a problem or proposing a feature.

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.

---

# فارسی

> یک ابزار سبک ویندوزی برای ادغام فایل‌های سورس بر اساس ماژول و پسوند فایل.

MergeFilesByExtension پوشه‌های سطح اول پروژه را بررسی می‌کند، پوشه‌های مرتبط را بر اساس نام ماژول گروه‌بندی می‌کند، فایل‌های دارای پسوندهای انتخاب‌شده را جمع می‌کند و برای هر ماژول یک فایل متنی خوانا می‌سازد.

این ابزار مخصوصاً برای بررسی سریع سورس پروژه‌های ماژولار، مستندسازی، تهیه نسخه متنی و آماده‌سازی کد برای تحلیل با هوش مصنوعی کاربرد دارد.

## قابلیت‌ها

- گروه‌بندی فایل‌ها بر اساس ماژول.
- انتخاب چند پسوند فایل، مانند `cs`، `cshtml` و `json`.
- حذف پوشه‌ها و فایل‌های دلخواه با Block List.
- نادیده گرفتن خودکار پوشه‌های `bin`، `obj`، `.vs` و `.git`.
- انتخاب مسیر دلخواه برای خروجی.
- اجرای پردازش در پس‌زمینه تا رابط کاربری قفل نشود.
- امکان لغو عملیات.
- نمایش وضعیت پردازش.
- ادامه پردازش در صورت خطای خواندن بعضی فایل‌ها و گزارش موارد ردشده.
- تولید خروجی مرتب و قابل پیش‌بینی.

## نحوه کار

ابزار برای پروژه‌هایی مناسب است که پوشه‌های سطح اول مرتبط، یک پیشوند ماژول مشترک داشته باشند.

مثلاً:

```text
MyProject/
├── Account.Application/
├── Account.Domain/
├── Account.Infrastructure/
├── Project.Application/
├── Project.Domain/
└── Task.Domain/
```

خروجی:

```text
Account.txt
Project.txt
Task.txt
```

نام ماژول از متن قبل از اولین نقطه `.` در نام پوشه استخراج می‌شود. بنابراین `Account.Domain` متعلق به ماژول `Account` است.

## استفاده

۱. پوشه اصلی پروژه را انتخاب کنید.

۲. پسوند فایل‌ها را وارد کنید. مثال:

```text
cs, cshtml, json
```

۳. پوشه‌ها یا فایل‌هایی که نباید پردازش شوند را وارد کنید. مثال:

```text
Migrations, Tests, generated.cs
```

۴. مسیر خروجی را انتخاب کنید.

۵. روی **Start merge** کلیک کنید.

۶. بعد از اتمام، پوشه خروجی را باز کنید.

پسوندها را می‌توان با یا بدون نقطه وارد کرد و تطبیق آن‌ها حساس به حروف بزرگ و کوچک نیست.

## فرمت خروجی

برای هر ماژول یک فایل متنی جدا ساخته می‌شود و مسیر نسبی هر فایل نیز داخل خروجی درج می‌شود.

## پیش‌نیاز

- Windows
- .NET Framework 4.8

## ساخت از سورس

فایل `MergeFilesByExtension.sln` را در Visual Studio باز کنید و پروژه را در حالت **Release** Build کنید.

در Developer PowerShell نیز می‌توانید استفاده کنید:

```powershell
msbuild MergeFilesByExtension.sln /p:Configuration=Release
```

## مشارکت

گزارش باگ، پیشنهاد قابلیت و Pull Request استقبال میشه.

برای گزارش باگ یا پیشنهاد قابلیت می‌توانید از Issue Templateهای آماده GitHub استفاده کنید.

## مجوز

این پروژه تحت مجوز MIT منتشر شده است. متن کامل مجوز در فایل [LICENSE](LICENSE) قرار دارد.
