function transform(ch)
    result = ch
    if ch >= 'α' && ch <= 'ω'
        return "?"
    end
    
    if isletter(ch)
        if isuppercase(ch)
            return "-" * string(lowercase(ch))
        else 
            return string(ch)
        end
    end
    
    if ch == '-' 
        result = '_'
    elseif isspace(ch) || isdigit(ch)
        result = ""
    else 
        result = ch
    end 

    return string(result)
end

function clean(str)
    join([transform(s) for s in str])
    
end
