# Bootstrap layout dynamic render (by C# ASP.NET Standard)
Динамическая вёрстка Bootstrap 4.3

about:
- в проекте присутусвуют классические **asp** компоненты и модели, а так же "управляющие сервисы"
- компоненты выполняют генерацию **html** разметки в момент вызова, а сервисы позволяют предварительно настроить этот процесс
- за каждым сервисом закрплён один из компонентов. Имя компонента (для рендеринга коненчого **html**) хранится в поле сервиса `public string ViewComponentName { get; }`
- готовый сервис можно отрисовать в **Razor .cshtml**: `@await Component.InvokeAsync(MyService.ViewComponentName, new { SetObjectManager = MyService })` (где **MyService** это готовый "управляющий сервис")
- компонент принимает сервис в виде парамтера и формирует нужный **html**

Пространсва имён (их всего 3) в вашем **Razor.cshtml**:
```cshtml
@using BootstrapAspDynamicRender.service // управляющие сервисы
@using BootstrapAspDynamicRender.models // вспомогательные модели
@using BootstrapAspDynamicRender.components // рендеринг-компоненты
```

Именование:
- все типы в проекте отвечают правилам именования, а точнее правилам префикса по первым двум (или трём) строчным буквам имени типа. Например: `hrOptionSelect`, `bmCustomInput` или `hsButton`
- каждый тип (будь то компонент, модель или сервис) в своём имени имеет вначале 2 (иногда 3) буквы по которым этот можно определить область применения
- в случае с абстарктным сервисом префикс состоит из трёх симовлов и начинается с символа `a`. Например: `ahsDisengageableDom`

Обозначение символов префикса:    
- **a** (=**abstract**) - означает, что класс абстрактный. _примечание: абстрактные типы могут встретиться в "управляющих классах"_
- **b** (=**Bootstrap**) - генерация **Bootstrap HTML** разметки
- **h** (=**HTML**) - генерация **native HTML** разметки
- **s** (=**Service**) - "управляющие сервисы"
- **m** (=**Model**) - вспомогательные модели. _примечание: для компонент в роли модели (`@model`) обычно выступают "управляющие сервисы"_
- **r** (=**Rendering**) - компоненты `ViewComponent`

## Navs[¶](https://getbootstrap.com/docs/4.3/components/navs/)
> [readme](./readme/nav/)

## Navbar[¶](https://getbootstrap.com/docs/4.3/components/navbar/)
> [readme](./readme/navbar/)

## Pagination[¶](https://getbootstrap.com/docs/4.3/components/pagination/)
> [readme](./readme/pagination)

## Breadcrumbs[¶](https://getbootstrap.com/docs/4.3/components/breadcrumb/)
> [readme](./readme/breadcrumbs/)

## Modal[¶](https://getbootstrap.com/docs/4.3/components/modal/)
> [readme](./readme/modal/)

## Forms[¶](https://getbootstrap.com/docs/4.3/components/forms/)
> [progress...](./readme/form/)

## Input group[¶](https://getbootstrap.com/docs/4.3/components/input-group/)
> [progress...](./readme/input-group/)

## Buttons[¶](https://getbootstrap.com/docs/4.3/components/buttons/)
> [progress...](./readme/button/)

## Button group[¶](https://getbootstrap.com/docs/4.3/components/button-group/#basic-example)
> [progress...](./readme/button-group)

## Tables[¶](https://getbootstrap.com/docs/4.3/content/tables/)
> [progress...](./readme/table/)

## List group[¶](https://getbootstrap.com/docs/4.3/components/list-group/)
> [progress...](./readme/list-group/)

## Carousel[¶](https://getbootstrap.com/docs/4.3/components/carousel/)
> [progress...](./readme/carousel/)

## Collapse[¶](https://getbootstrap.com/docs/4.3/components/collapse/)
> [progress...](./readme/collapse/)

## Dropdowns[¶](https://getbootstrap.com/docs/4.3/components/dropdowns/)
> [progress...](./readme/dropdown/)

## Cards[¶](https://getbootstrap.com/docs/4.3/components/card/)
> [progress...](./readme/card/)

## Media object[¶](https://getbootstrap.com/docs/4.3/components/media-object/)
> [progress...](./readme/media-object/)

## Progress[¶](https://getbootstrap.com/docs/4.3/components/progress/)
> [progress...](./readme/progress/)

## Scrollspy[¶](https://getbootstrap.com/docs/4.3/components/scrollspy/)
> [progress...](./readme/scrollspy)