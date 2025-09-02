--
-- DESCRIPTION
--
-- @COMPANY **
-- @AUTHOR **
-- @DATE ${date} ${time}
--

---@type BP_helloworld_C
local M = UnLua.Class()

function M:Initialize()
    local msg = "Hello World! —— 来自 Lua 脚本"
    
    -- 日志打印
    print(msg)
    
    -- 屏幕打印 (如果你的项目已经有 Screen.Print 封装)
    if Screen then
        Screen.Print(msg)
    else
        print("Screen.Print 未定义，无法在屏幕上显示消息")
    end
end

-- 或者在 BeginPlay 打印
function M:ReceiveBeginPlay()
    local msg = "Hello World from BeginPlay!"
    print(msg)
    if Screen then
        Screen.Print(msg)
    end
end

return M
-- function M:Initialize(Initializer)
-- end

-- function M:UserConstructionScript()
-- end

-- function M:ReceiveBeginPlay()
-- end

-- function M:ReceiveEndPlay()
-- end

-- function M:ReceiveTick(DeltaSeconds)
-- end

-- function M:ReceiveAnyDamage(Damage, DamageType, InstigatedBy, DamageCauser)
-- end

-- function M:ReceiveActorBeginOverlap(OtherActor)
-- end

-- function M:ReceiveActorEndOverlap(OtherActor)
-- end

