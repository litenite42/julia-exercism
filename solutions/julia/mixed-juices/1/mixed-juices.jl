function time_to_mix_juice(juice)
    if juice == "Pure Strawberry Joy" 
        return .5
    elseif juice == "Energizer" || juice == "Green Garden"
        return 1.5
    elseif juice == "Tropical Island"
        return 3
    elseif juice == "All or Nothing"
        return 5
    else
        return 2.5
    end
end

function wedges_from_lime(size)
    if size == "small"
        return 6
    elseif size == "medium"
        return 8
    else
        return 10
    end
end

function limes_to_cut(needed, limes)
    @show(needed)
    @show(limes)
    if limes.size == 0
        return 0
    end
    
    wedges = [wedges_from_lime(lime) for lime in limes]
    
    count = 0
    remaining = needed
    
    while remaining > 0 && length(wedges) > 0           
        curr = popfirst!(wedges)
        
        remaining -= curr
        count += 1
    end
    
    return count
end

function order_times(orders)
    return [time_to_mix_juice(order) for order in orders]
end

function remaining_orders(time_left, orders)
    times = order_times(orders)
    result = []
    
    for time in times 
        if time_left <= 0
            break
        end
        
        time_left -= time
        popfirst!(orders)
    end

    return orders
end
