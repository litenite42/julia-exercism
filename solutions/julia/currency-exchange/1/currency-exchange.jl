function exchange_money(budget, exchange_rate)
    return budget / exchange_rate
end

function get_change(budget, exchanging_value)
    return budget - exchanging_value
end

function get_value_of_bills(denomination, number_of_bills)
    return denomination * number_of_bills
end

function get_number_of_bills(amount, denomination)
    return floor(amount / denomination)
end

function get_leftover_of_bills(amount, denomination)
    exc = get_number_of_bills(amount, denomination)

    return amount - get_value_of_bills(denomination, exc)
end

function exchangeable_value(budget, exchange_rate, spread, denomination)
    new_exc = exchange_rate + ( exchange_rate * (spread / 100) )
    new_val = get_number_of_bills(exchange_money(budget, new_exc), denomination)
    return get_value_of_bills(denomination, new_val)
end
