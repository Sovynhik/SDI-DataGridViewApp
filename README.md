# Лабораторная работа №4  
**Дисциплина:** Проектирование программного интерфейса  
**Тема:** Создание приложения типа *Windows Forms Application* с применением Visual C#  
**Вариант 16** — Работа с `DataGridView`, `XML`, `PictureBox`, модальный поиск

---

## Цель работы
Получение практических навыков разработки оконных приложений для Windows с применением Visual C#, изучение программной среды Microsoft Visual Studio и свойств визуальных компонентов:  
- `DataGridView`  
- `XML` (сохранение/загрузка)  
- `PictureBox` (загрузка фото)  
- Модальное окно поиска  
- `TableLayoutPanel` (масштабируемый UI)

---

## Задание
Создать **базу пользователей** с возможностью:  
1. Добавления, редактирования, удаления записей  
2. Сохранения/загрузки в `users.xml`  
3. Загрузки фото  
4. Поиска по фамилии (в модальном окне)  
5. Масштабируемого интерфейса

---

## Требования
- **Visual Studio 2022+**  
- **.NET Framework 4.8** (или .NET 6+ Windows)  
- Язык: **C#**

---

## Структура проекта
```
Lab4_Variant16/
├── Program.cs
├── FormMain.cs
├── FormMain.Designer.cs
├── FormSearch.cs
├── FormSearch.Designer.cs
├── users.xml            ← создаётся при сохранении
├── README.md
└── screenshots/
    ├── main.png
    ├── add.png
    ├── search.png
    └── xml.png
```

---

## Запуск проекта
1. Откройте Visual Studio  
2. **File → Open → Project/Solution**  
3. Выберите `Lab4_Variant16.csproj`  
4. Нажмите **F5**

---

## Интерфейс (описание)

| Область | Компоненты |
|--------|-----------|
| **Левая панель** | Поля ввода: Фамилия, Имя, Отчество, Активен, Дата, Пол, Фото |
| **Правая панель** | `DataGridView` — таблица пользователей |
| **Нижняя левая** | Кнопки: Добавить, Изменить, Удалить, Очистить, Сохранить XML, Загрузить XML |
| **Нижняя правая** | Поиск: [________] [Найти] → открывает модальное окно |

---

## Скриншоты

### Главное окно
![Главное окно](screenshots/main.png)

### Добавление записи
![Добавление](screenshots/add.png)

### Поиск (модальное окно)
![Поиск](screenshots/search.png)

### Файл `users.xml`
![XML](screenshots/xml.png)

---

## Код (ключевые фрагменты)

### `FormMain.cs` — Добавление записи
```csharp
private void btnAdd_Click(object sender, EventArgs e)
{
    int idx = dgwUsers.Rows.Add();
    FillRow(dgwUsers.Rows[idx]);
    ClearInputFields();
}
```

### Сохранение в XML
```csharp
ds.WriteXml("users.xml");
```

### Загрузка фото
```csharp
pbPhoto.Image = Image.FromFile(ofd.FileName);
```

### Поиск → модальное окно
```csharp
using (var form = new FormSearch())
{
    form.ShowResults(results);
    form.ShowDialog();
}
```

---

## Используемые компоненты

| Компонент | Свойства |
|---------|---------|
| `DataGridView` | `Dock=Fill`, `SelectionMode=FullRowSelect` |
| `TableLayoutPanel` | `Dock=Fill`, `%` для колонок/строк |
| `PictureBox` | `SizeMode=Zoom`, `BorderStyle=FixedSingle` |
| `ComboBox` | `DropDownStyle=DropDownList`, `Items: Мужской, Женский` |
| `DateTimePicker` | `Format=Short` |
| `OpenFileDialog` | `Filter=Изображения` |

---

## Результаты

- Реализована **полноценная база пользователей**  
- **XML I/O** с сохранением фото (`byte[]`)  
- **Модальный поиск**  
- **Масштабируемый UI**  
- Проект **компилируется и запускается без ошибок**

---

## Автор
**Савушкин Д.А.** - студент РГРТУ
---
