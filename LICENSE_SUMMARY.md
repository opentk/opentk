# OpenTK TL;DR License Summary
### Introduction
Thank you for using OpenTK, we're glad to have you on board! In order to make our licensing schemes as compatible as
they can be with all projects, we have multiple licenses. This summary document has been created to ensure that our end
users can understand these licenses, and the impact of them on their projects; without having to sift through boring
legalese documents.

### OpenTK and the MIT license
OpenTK is licensed under the [MIT License](LICENSE.md), as shown in the [LICENSE.md](LICENSE.md) file. The MIT License
essentially allows you to **do anything** with OpenTK, **as long as you include the license file** and **keep the
license header in our files**.

[See the MIT license terms](https://choosealicense.com/licenses/mit/)

### AdvancedDLSupport
OpenTK uses AdvancedDLSupport for added compatibility with .NET Core, and to maximize performance. **AdvancedDLSupport
("ADL") is licensed under LGPLv3**; which requires that all projects that release ADL are LGPL or GPL. This causes a
license conflict between MIT and LGPLv3 and, as such, a custom license is required.

[See the Lesser General Public License (LGPL) terms](https://choosealicense.com/licenses/lgpl-3.0/)

### Our license grant
Firwood Software, the creators of ADL, were nice enough to provide the OpenTK project a license grant free of charge.
**This license grant relaxes the requirement that anything that uses ADL is LGPL**, meaning that our MIT license is
valid. However, it has limitations:
* **You must not use ADL outside of OpenTK**. Essentially, only the OpenTK code is allowed to reference ADL. **If you
use ADL's API where OpenTK doesn't require it, the entire LGPLv3 applies to your project.**
* Your project, and any derivatives, are bound by this license grant.

### The do's and don'ts
* **Do** use OpenTK in your project using the MIT license.
* **Do** make projects that depend on OpenTK with **whatever license**, provided the licenses don't undermine any of the
OpenTK licenses.
* **Don't** use AdvancedDLSupport outside of OpenTK, because you'll have to comply with LGPLv3 otherwise.
* **Don't** undermine the license grant - you'll make it angry.

Basically, you can redistribute ADL as long as *you* don't use it, and only OpenTK does.

### Disclaimer
If you do wish to use ADL outside of OpenTK and aren't able to use LGPL, feel free to get in touch with
@Firwood-Software to figure out a custom licensing scheme.

Again, thanks for using OpenTK; we hope you enjoy it! :)

- Team OpenTK.
