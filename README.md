# cs-form-mtn-011-vs2022

所属マスタを作成して、そこから一覧を選択可能にすめコンボボックスの実装

```sql
CREATE TABLE `所属マスタ` (
  `所属コード` varchar(4) NOT NULL,
  `所属名称` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`所属コード`)
)
```

![image](https://github.com/winofsql/cs-form-mtn-011-vs2022/assets/1501327/ddcb83ff-e581-43f2-b72e-3ad32286dea3)

<br><br>

## 🔴 ソース分割されているソリューションを読み込んだ場合必ず最初に以下の設定が必要です

### 入れ子機能( Web ) を使用した機能のソース分割( partial )

![image](https://github.com/winofsql/cs-form-mtn-010-vs2022/assets/1501327/171c8266-a28f-4dbd-a7b9-ef208e0615c6)

