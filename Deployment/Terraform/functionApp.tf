module "azureFunctionApp"{
  source                = "./TerraformModules/Modules/AzureFunctionApp/1.0"
  ResourceGroupName     = "${azurerm_resource_group.resourceGroup1.name}"
  ResourceGroupLocation = "${azurerm_resource_group.resourceGroup1.location}"
  StorageAccountName    = "${var.StorageAccountName}"
  AppServicePlanName    = "${var.AppServicePlanName}"
  FunctionAppName       = "${var.FunctionAppName}"
}
