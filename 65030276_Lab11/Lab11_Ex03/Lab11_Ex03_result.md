# 3.1
<img width="641" alt="Screenshot 2024-03-30 221453" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-11/assets/144866059/99c4995f-018d-40b7-a7c9-7422ea0c1d85">

# 3.2
<img width="637" alt="Screenshot 2024-03-30 221505" src="https://github.com/anndyyzzz/03376836-OOP-2566-Lab-11/assets/144866059/ec17a991-7cbe-47ff-a48a-fee5e80a4412">

#### ในการทดลองนี้มีการสร้างและใช้งานคลาสและเมทอดเพื่อจำลองการเคลื่อนไหวของสัตว์ต่าง ๆ โดยมีคลาส Animal เป็นคลาสหลักที่มีเมทอด Move() ที่ถูกประกาศเป็น virtual เพื่อให้สามารถโอเวอร์ไรด์ได้ และมีคลาส Dog, Fish, และ Bird เป็นคลาสลูกที่โอเวอร์ไรด์เมทอด Move() เพื่อระบุการเคลื่อนไหวของแต่ละสัตว์ นอกจากนี้ ในเมทอด Move() ของแต่ละคลาสยังมีการเรียกใช้เมทอด Move() ของคลาสหลัก (base.Move()) เพื่อแสดงข้อความ "Move successfully." ที่เป็นข้อความที่เหมือนกันทุกครั้งที่เคลื่อนไหว สรุปได้ว่า โค้ดนี้เป็นตัวอย่างการใช้งานการโอเวอร์ไรด์และการใช้งานเมทอดเบื้องต้นใน C# อย่างมีประสิทธิภาพและยืดหยุ่น