--
-- DESCRIPTION
--
-- @COMPANY **
-- @AUTHOR **
-- @DATE ${date} ${time}
--

---@type BP_helloworld_C
local M = UnLua.Class()

local AccumulatedTime = 0
-- function print on screen

function M:ReceiveTick(DeltaSeconds)
    AccumulatedTime = AccumulatedTime + DeltaSeconds
    if AccumulatedTime >= 2.0 then
        self:PrintString("Hello World Tick", 2.0, true)
        AccumulatedTime = 0
    end
end

return M
