-entity-heater-setting-name =
    { $setting ->
        [off] off
        [low] low
        [medium] medium
        [high] high
       *[other] unknown
    }

entity-heater-examined = It is set to { $setting ->
    [off] [color=gray]{ -entity-heater-setting-name }[/color]
    [low] [color=yellow]{ -entity-heater-setting-name }[/color]
    [medium] [color=orange]{ -entity-heater-setting-name }[/color]
    [high] [color=red]{ -entity-heater-setting-name }[/color]
   *[other] [color=purple]{ -entity-heater-setting-name }[/color]
}.
entity-heater-switch-setting = Switch to { -entity-heater-setting-name }
entity-heater-switched-setting = Switched to { -entity-heater-setting-name }.
