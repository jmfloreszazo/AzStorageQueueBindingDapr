# Dapr Binding with Azure Storage Queue in C#

[In this links you can view the official documentation about Bindings](https://docs.dapr.io/reference/components-reference/supported-bindings/).

## Create Azure Resource Group:

```terminal
az group create -l westeurope -n MyResourceGroup
```

## Create Azure Storage Account:

```terminal
az storage account create -n mydaprdemostorageaccount -g MyResourceGroup -l westeurope --sku Standard_LRS
```

And queue:

```terminal
az storage queue create -n myqueue --account-name mydaprdemostorageaccount
```

[![GitKraken shield](https://img.shields.io/badge/GitKraken-Legendary%20Git%20Tools-teal?style=plastic&logo=gitkraken)](https://gitkraken.com/invite/sUviHf86)

[![MIT License](https://img.shields.io/apm/l/atomic-design-ui.svg?)](https://github.com/tterb/atomic-design-ui/blob/master/LICENSEs)