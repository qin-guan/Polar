<#
.SYNOPSIS
Build helper

.DESCRIPTION
USAGE
    .\build.ps1 <command>

COMMANDS
    codegen         generates bindings
    help, -?        show this help message
#>

[CmdletBinding()]
Param(
    [Parameter(Position = 0)]
    [ValidateSet("codegen", "help")]
    [string]$Command,
    [Parameter(Position = 1, ValueFromRemainingArguments = $true)]
    [string[]]$Arguments
)

function Command-Codegen
{
    kiota generate --output ./Polar.OpenAPI/Src/ -l CSharp -d https://api.polar.sh/openapi.json -c PolarClient -n Polar.OpenAPI --co
}

function Command-Help
{
    Get-Help $PSCommandPath
}

Switch ($Command)
{
    "codegen" {
        Command-Codegen
    }
    "help" {
        Command-Help
    }
    default {
        Command-Help
    }
}