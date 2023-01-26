<div align = "center">
<img src="Assets/screenshot.jpg" width="700" />
</div>

<p align="center">
<img src="https://img.shields.io/badge/ASP.NET%20Core%20MVC-6.0-blue.svg" alt="ASP.NET Core MVC 4.0"/>
</a>
</p>

# Alerts & Pickers

Advanced usage of native UIAlertController with TextField, TextView, DatePicker, PickerView, TableView, CollectionView and MapView.



### Features
- [x] Custom pickers based on UITextField, UITextView, UIDatePicker, UIPickerView, UITableView, UICollectionView and MKMapView.
- [x] Example using a Storyboard.
- [x] Easy contentViewController placement.
- [x] Attributed title label and message label.
- [x] Button customization: image and title color.
- [x] Understandable action button placement.
- [x] Easy presentation.
- [x] Pure Swift 4.

<div align = "center">
<img src="Assets/gifs/actionSheet-.gif" width="400" />
<img src="Assets/gifs/alert-.gif" width="400" />
</div>

## Usage

- New Alert

```swift
let alert = UIAlertController(style: .alert, title: "Title", message: "Message")
// or
let alert = UIAlertController(style: .alert)
```

## Alerts vs. Action Sheets

There are some things to keep in mind when using `.actionSheet` and `.alert` styles:

* Pickers better to use in `.actionSheet` style.
* `UITextField` can be used in both styles.

## Installing

#### Manually

Download and drop `/Source` folder in your project.

## Requirements

* Swift 4
* iOS 11 or higher

## Authors

* **Roman Volodko** -  [dillidon](https://github.com/dillidon)

## Communication

* If you **found a bug**, open an issue.
* If you **have a feature request**, open an issue.
* If you **want to contribute**, submit a pull request.

## License

This project is licensed under the MIT License.
