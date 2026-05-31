# Define the `expected_bake_time` constant`
const expected_bake_time = 60
const minutes_per_layer = 2
# Define the `preparation_time(layers)` function.
preparation_time(layers) = minutes_per_layer * layers
# Define the `remaining_time(time_in_oven)` function.
remaining_time(in_oven_time) = expected_bake_time - in_oven_time
# Define the `total_working_time(layers, time_in_oven)` function.
function total_working_time(layers, in_oven_time) 
    preparation_time(layers) + in_oven_time
end
