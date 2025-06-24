> **Language Notice**: 
> [View in English (الإنجليزية)](README.md) |


# عرض توضيحي لخاصية السعة والعدد في قائمة سي شارب

يوضح هذا البرنامج المكتوب بلغة C# كيفية تغير خصائص `Count` و `Capacity` في قائمة من نوع `List<int>` ديناميكيًا عند إضافة وإزالة العناصر، ويعرض آلية تغيير السعة التلقائية في مجموعة `List<T>` الخاصة بـ .NET.

## المفاهيم الرئيسية الموضحة
- **العدد مقابل السعة**: 
  - `Count` = عدد العناصر الفعلي في القائمة
  - `Capacity` = إجمالي مساحة التخزين المخصصة
- مضاعفة السعة تلقائيًا عند إضافة عناصر تتجاوز السعة الحالية
- تأثير عمليات `Remove()` و `RemoveRange()`
- تأثير `TrimExcess()` في تقليل السعة

## كيفية التشغيل
1. **المتطلبات المسبقة**: تثبيت [.NET SDK](https://dotnet.microsoft.com/download/download) (الإصدار 5.0+ موصى به)
2. استنساخ المستودع:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   ```
3. تشغيل البرنامج:
   ```bash
   cd your-repo-name
   dotnet run
   ```

## المخرجات المتوقعة
``````
After Creation             Count    :  0, Capacity :  0
After Adding 1             Count    :  1, Capacity :  4
After Adding 2             Count    :  2, Capacity :  4
After Adding 3             Count    :  3, Capacity :  4
After Adding 4             Count    :  4, Capacity :  4
After Adding 5             Count    :  5, Capacity :  8
After Adding 6,7,8         Count    :  8, Capacity :  8
After Adding 9             Count    :  9, Capacity : 16
After Removing 1           Count    :  8, Capacity : 16
After Removing 3 items from index 2 Count    :  5, Capacity : 16
After TrimExcess           Count    :  5, Capacity :  5

```

## شرح السلوك
1. **التهيئة**: تبدأ القائمة الفارغة بسعة 0
2. **إضافة العناصر**:
   - تتضاعف السعة عند تجاوز الحد الحالي (4 ← 8 ← 16)
   - السعة الابتدائية الافتراضية بعد أول إضافة: 4
3. **إزالة العناصر**:
   - عمليات `Remove()` و `RemoveRange()` تقلل العدد لكن ليس السعة
   - تبقى السعة كما هي حتى يتم ضبطها يدويًا
4. **TrimExcess()**:
   - يقلل السعة لتطابق العدد الحالي
   - يؤثر فقط إذا كان أكثر من 90% من المساحة غير مستخدم

## فهم المخرجات
- لاحظ كيف تنمو السعة بشكل أسّي (0 → 4 → 8 → 16) لتحسين الأداء
- إزالة العناصر لا تقلل السعة تلقائيًا
- `TrimExcess()` يستعيد الذاكرة غير المستخدمة عند وجود هدر كبير للمساحة

يوضح هذا العرض التوضيحي المقايضة بين الأداء والذاكرة في تنفيذ قوائم .NET، مع الحفاظ على الكفاءة أثناء عمليات الإضافة/الإزالة المتكررة.
