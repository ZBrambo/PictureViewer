# PictureViewer

A simple **Windows Forms Picture Viewer** application built with **C# and .NET Framework 4.8**. The application provides a straightforward graphical interface for opening and displaying images while giving the user basic controls for managing how an image is presented.

## Overview

PictureViewer was created as a desktop application project to practice developing graphical user interfaces with **C# and Windows Forms**.

The application uses standard Windows Forms components such as `PictureBox`, `OpenFileDialog`, `ColorDialog`, buttons, and a checkbox to provide an interactive image-viewing experience.

## Features

* **Open Image** — Browse for an image file and display it in the application.
* **Clear Image** — Remove the currently displayed image.
* **Set Background Color** — Select a custom background color for the image area.
* **Clear Background** — Reset the PictureBox background to transparent.
* **Stretch Image** — Toggle between the normal image display mode and stretching the image to fit the PictureBox.

## Technologies

* **C#**
* **Windows Forms**
* **.NET Framework 4.8**
* **Visual Studio**

## Getting Started

### Prerequisites

To build and run this project, you will need:

* Windows
* Visual Studio with Windows Forms/.NET Framework development support
* .NET Framework 4.8

### Installation

1. Clone the repository:

```bash
git clone https://github.com/ZBrambo/PictureViewer.git
```

2. Open `PictureViewer.slnx` in Visual Studio.

3. Build the solution.

4. Run the application.

## How to Use

### Open an Image

Click the **Show Picture** button to open the file browser. Select an image file and the application will display it inside the PictureBox.

### Clear an Image

Click **Clear Picture** to remove the currently displayed image.

### Change the Background

Click **Set Background Color** to open the color selection dialog. Choose a color to change the PictureBox background.

### Reset the Background

Click **Clear Background** to return the PictureBox background to transparent.

### Stretch the Image

Use the **Stretch Image** checkbox to toggle image stretching.

When enabled, the image is resized to fit the PictureBox. When disabled, the image returns to its normal display mode.

## Project Structure

```text
PictureViewer/
├── Properties/
├── App.config
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── PictureViewer.csproj
├── PictureViewer.slnx
├── Program.cs
└── README.md
```

### Important Files

| File                   | Description                                                       |
| ---------------------- | ----------------------------------------------------------------- |
| `Program.cs`           | Contains the application's entry point.                           |
| `Form1.cs`             | Contains the primary application logic and button event handlers. |
| `Form1.Designer.cs`    | Contains the Windows Forms UI designer-generated code.            |
| `Form1.resx`           | Contains form resources.                                          |
| `PictureViewer.csproj` | Contains the project configuration and dependencies.              |
| `PictureViewer.slnx`   | Visual Studio solution file.                                      |

## What I Learned

This project provided practice with:

* Creating a desktop application using Windows Forms
* Designing a graphical user interface
* Working with Windows Forms controls
* Handling button and checkbox events
* Using `OpenFileDialog` to select files
* Using `ColorDialog` to select colors
* Loading images into a `PictureBox`
* Changing `PictureBox` properties at runtime
* Organizing a C# Windows Forms project

## Future Improvements

Potential improvements for future versions include:

* Support for navigating through multiple images in a folder
* Zoom and image-scaling controls
* Image rotation
* Additional image formats
* Drag-and-drop image support
* Full-screen viewing
* Image information such as dimensions and file size
* Improved UI styling

## Author

**Zachary Bram**

GitHub: [ZBrambo](https://github.com/ZBrambo)

## License

This project is intended for educational and portfolio purposes.
