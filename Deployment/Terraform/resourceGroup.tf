resource "azurerm_resource_group" "resourceGroup1" {
  name     = "${var.ResourceGroupName}"
  location = "${var.ResourceGroupLocation}"
}
