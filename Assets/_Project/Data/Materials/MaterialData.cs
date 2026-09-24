using System;

[Serializable]
public class MaterialData
{
    public string materialID;
    public string materialName;
    public string materialDescription;
    public string materialUsage;
    public string materialType;
    public string materialFiveElements;
    public int materialTier;

    // Đặc thù riêng cho từng loại nguyên liệu (thảo mộc có tuổi thọ, khoáng thạch có đặc tính riêng)
    public int minYear;                // Dùng cho Thảo mộc (là 0 nếu không có yêu cầu)
    public int maxYear;                // Dùng cho Thảo mộc
 
}