using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
public class dangnhaptk : MonoBehaviour
{
    public TMP_InputField username;
    public TMP_InputField password;
    public TextMeshProUGUI thongbao;
    public string namescene = "dangky";
    public void dangnhapbuton()
    {
        StartCoroutine(DangNhap());
    }
    public void trolaidk()
    {
        SceneManager.LoadScene(namescene);

    }
    IEnumerator DangNhap()
    {
        WWWForm form = new WWWForm();
        form.AddField("user", username.text);
        form.AddField("passwd", password.text);

        UnityWebRequest www = UnityWebRequest.Post("https://fpl.expvn.com/dangnhap.php", form);
        yield return www.SendWebRequest();

        if (!www.isDone)
        {
            thongbao.text = "Kết nối không thành công";
        }
        else
        {

            string get = www.downloadHandler.text;
            if (get == "empty")
            {
                thongbao.text = "Không để các trường dữ liệu trống";
            }else if (get == "" || get == null)
            {
                thongbao.text = "Tài khoản mật khẩu không chính xác";
            }else if (get.Contains("Lỗi"))
            {
                thongbao.text = "Không kết nối được tới sever";
            }
            else
            {
                thongbao.text = "Đăng nhập thành công";
                PlayerPrefs.SetString("token", get);
                Debug.Log(get);
            }
            
        }
    }
}